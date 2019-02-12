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
    }
}
