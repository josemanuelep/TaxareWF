using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Produccion
    {

        public long id { get; set; }
        public Nullable<long> idTurno { get; set; }
        public double producido { get; set; }
    }
}
