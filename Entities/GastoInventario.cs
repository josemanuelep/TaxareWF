using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class GastoInventario
    {

        public long id { get; set; }
        public string objinventario { get; set; }
        public string placaTaxi { get; set; }
        public int cantidadUsada { get; set; }
        public System.DateTime fecha { get; set; }
    }
}
