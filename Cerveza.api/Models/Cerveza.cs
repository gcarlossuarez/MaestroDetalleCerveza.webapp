using System;
using System.Collections.Generic;

namespace Cerveza.api.Models
{
    public partial class Cerveza
    {
        public Cerveza()
        {
            Ingrediente = new HashSet<Ingrediente>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Estilo { get; set; }

        public virtual ICollection<Ingrediente> Ingrediente { get; set; }
    }
}
