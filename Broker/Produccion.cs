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
    
    public partial class Produccion
    {
        public Produccion(string placa, int id_taxista, DateTime inicio, DateTime final, double valor, Taxis taxis)
        {
            this.placa = placa;
            this.id_taxista = id_taxista;
            this.inicio = inicio;
            this.final = final;
            this.valor = valor;
            Taxis = taxis;
        }

        public int id { get; set; }
        public string placa { get; set; }
        public int id_taxista { get; set; }
        public System.DateTime inicio { get; set; }
        public System.DateTime final { get; set; }
        public double valor { get; set; }
    
        public virtual Taxis Taxis { get; set; }
    }
}
