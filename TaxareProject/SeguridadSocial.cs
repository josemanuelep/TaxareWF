//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaxareProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class SeguridadSocial
    {
        public int id { get; set; }
        public int id_conductor { get; set; }
        public System.DateTime pago_anterior { get; set; }
        public System.DateTime pago_siguiente { get; set; }
        public double valor { get; set; }
    
        public virtual Conductor Conductor { get; set; }
    }
}