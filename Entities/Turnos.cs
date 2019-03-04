using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public  class Turnos
    {

        public long id { get; set; }
        public string placaTaxi { get; set; }
        public string conductor { get; set; }
        public System.DateTime inicio { get; set; }
        public System.DateTime fin { get; set; }

        //Metodo constructor
        public Turnos(long id, string placaTaxi, string conductor, DateTime inicio, DateTime fin)
        {
            this.id = id;
            this.placaTaxi = placaTaxi;
            this.conductor = conductor;
            this.inicio = inicio;
            this.fin = fin;
        }

       

    }
}
