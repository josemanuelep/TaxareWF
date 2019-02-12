using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public  class SeguridadSocial
    {
        public int id { get; set; }
        public string conductor { get; set; }
        public System.DateTime pago_anterior { get; set; }
        public System.DateTime pago_siguiente { get; set; }
        public double valor { get; set; }
    }
}
