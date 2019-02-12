using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class GastosVariables
    {

        public int id { get; set; }
        public string placa { get; set; }
        public string descripcion { get; set; }
        public System.DateTime fecha { get; set; }
        public double kilometraje { get; set; }
        public double valor { get; set; }
    }
}
