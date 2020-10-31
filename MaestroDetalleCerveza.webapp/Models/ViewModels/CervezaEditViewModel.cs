using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaestroDetalleCerveza.webapp.Models.ViewModels
{
    public class CervezaEditViewModel
    {
        public int IdCerveza {get; set;}
        public string Nombre { get; set; }
        public string Estilo { get; set; }

        public List<IngredienteEditViewModel> ingredientes { get; set; }
    }

    public class IngredienteEditViewModel
    {
        public int IdIngrediente { get; set; }
        public string NombreIngrediente { get; set; }
        public int Gramos { get; set; }

        public int IdCerveza { get; set; }
    }
}
