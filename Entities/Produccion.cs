using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Produccion
    {

        public long id { get; set; }
        public double producido { get; set; }
        public string placa  { get; set; }
        public string conductor { get; set; }
        public int dias { get; set; }
        public System.DateTime inicio { get; set; }
        public System.DateTime final { get; set; }

        public Produccion(){ }
    
    //Metodo Constructor
    public Produccion(long id, double producido, string placa, string conductor, int dias)
        {
            this.id = id;
            this.producido = producido;
            this.placa = placa;
            this.conductor = conductor;
            this.dias = dias;
        }
    }
}
