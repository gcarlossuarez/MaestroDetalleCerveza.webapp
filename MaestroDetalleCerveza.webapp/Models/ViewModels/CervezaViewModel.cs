using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace MaestroDetalleCerveza.webapp.Models.ViewModels
{
    public class CervezaViewModel
    {
        public string Nombre { get; set; }
        public string Estilo { get; set; }

        public List<Ingrediente> ingredientes { get; set; }
    }

    public class Ingrediente
    {
        public string NombreIngrediente { get; set; }
        public int Gramos { get; set; }
    }
}
