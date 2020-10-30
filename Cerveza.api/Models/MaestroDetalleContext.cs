using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Cerveza.api.Models
{
    public partial class MaestroDetalleContext : DbContext
    {
        public MaestroDetalleContext()
        {
        }

        public MaestroDetalleContext(DbContextOptions<MaestroDetalleContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cerveza> Cerveza { get; set; }
        public virtual DbSet<Ingrediente> Ingrediente { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-TQ5EDHD;Initial Catalog=MaestroDetalle;User ID=sa;Password=armagedon0;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cerveza>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Estilo)
                    .IsRequired()
                    .HasColumnName("estilo")
                    .HasMaxLength(50);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Ingrediente>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Gramos).HasColumnName("gramos");

                entity.Property(e => e.IdCerveza).HasColumnName("id_cerveza");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdCervezaNavigation)
                    .WithMany(p => p.Ingrediente)
                    .HasForeignKey(d => d.IdCerveza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ingrediente_Cerveza");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
