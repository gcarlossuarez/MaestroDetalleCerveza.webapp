using System;
using System.Collections.Generic;

namespace Cerveza.api.Models
{
    public partial class Ingrediente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Gramos { get; set; }
        public int IdCerveza { get; set; }

        public virtual Cerveza IdCervezaNavigation { get; set; }
    }
}
