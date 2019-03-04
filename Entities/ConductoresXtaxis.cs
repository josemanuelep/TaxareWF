using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ConductoresXtaxis
    {
        public long id { get; set; }
        public string conductor { get; set; }
        public string placaTaxi { get; set; }

        //Metodo constructor
        public ConductoresXtaxis(long id, string conductor, string placaTaxi)
        {
            this.id = id;
            this.conductor = conductor;
            this.placaTaxi = placaTaxi;
        }
    }


}
