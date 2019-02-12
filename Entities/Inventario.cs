using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Inventario
    {

        public long id { get; set; }
        public string item { get; set; }
        public int cantidad { get; set; }
        public string descripcion { get; set; }
    }
}
