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
    
    public partial class Kilometrajes
    {
        /// <summary>
        /// Metodo constructor
        /// </summary>
        /// <param name="placa"></param>
        /// <param name="kilometraje"></param>
        /// <param name="fecha"></param>
        public Kilometrajes(string placa, double kilometraje, System.DateTime fecha)
        {

            this.placa = placa;
            this.kilometraje = kilometraje;
            this.fecha = fecha;

        }
        public long id { get; set; }
        public string placa { get; set; }
        public double kilometraje { get; set; }
        public System.DateTime fecha { get; set; }
    
        public virtual Taxis Taxis { get; set; }
    }
}
