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
    
    public partial class Tecnomecanica
    {
        public int id { get; set; }
        public string placa { get; set; }
        public System.DateTime expedicion { get; set; }
        public System.DateTime vencimiento { get; set; }
        public Nullable<double> valor { get; set; }
    
        public virtual Taxis Taxis { get; set; }

        public Tecnomecanica(int id, string placa, System.DateTime expedicion, System.DateTime vencimiento,double valor) {

            this.id = id;
            this.placa = placa;
            this.expedicion = expedicion;
            this.vencimiento = vencimiento;
            this.valor= valor;
        }
    }
}