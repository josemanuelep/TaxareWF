using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public  class SeguridadSocial
    {
        public int id { get; set; }
        public string conductor { get; set; }
        public System.DateTime pago_anterior { get; set; }
        public System.DateTime pago_siguiente { get; set; }
        public double valor { get; set; }

        public SeguridadSocial(int id, string conductor, DateTime pago_anterior, DateTime pago_siguiente, double valor)
        {
            this.id = id;
            this.conductor =conductor;
            this.pago_anterior = pago_anterior;
            this.pago_siguiente = pago_siguiente;
            this.valor = valor;
        }
    }
}
