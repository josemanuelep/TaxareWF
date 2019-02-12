using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Responsabilidades
    {
        public int id { get; set; }
        public string placa { get; set; }
        public int poliza { get; set; }
        public string aseguradora { get; set; }
        public System.DateTime vencimiento { get; set; }
        public double valor { get; set; }
    }
}
