//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sicse.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Escaleras
    {
        public int idEscalera { get; set; }
        public string codigo { get; set; }
    
        public virtual Equipos Equipos { get; set; }
    }
}
