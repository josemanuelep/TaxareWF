//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Broker
{
    using System;
    using System.Collections.Generic;
    
    public partial class ConductoresXtaxis
    {
        public long id { get; set; }
        public long idConductor { get; set; }
        public string placaTaxi { get; set; }

        public ConductoresXtaxis() {


        }
        public ConductoresXtaxis(long idConductor, string placaTaxi)
        {
            this.idConductor = idConductor;
            this.placaTaxi = placaTaxi;
        }

        public virtual Conductor Conductor { get; set; }
        public virtual Taxis Taxis { get; set; }
    }
}