using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class SeguridadSocial
    {
        public int id { get; set; }
        public long id_conductor { get; set; }
        public System.DateTime pago_anterior { get; set; }
        public System.DateTime pago_siguiente { get; set; }
        public double valor { get; set; }
    }
}
