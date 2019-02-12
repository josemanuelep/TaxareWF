using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Turnos
    {

        public long id { get; set; }
        public string placaTaxi { get; set; }
        public long idConductor { get; set; }
        public System.DateTime inicio { get; set; }
        public System.DateTime fin { get; set; }
    }
}
