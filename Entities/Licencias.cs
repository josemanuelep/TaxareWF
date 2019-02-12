using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Licencias
    {
        public long Numero_pase { get; set; }
        public string conductor { get; set; }
        public string secretaria { get; set; }
        public string categoria { get; set; }
        public System.DateTime expedicon { get; set; }
        public System.DateTime vencimiento { get; set; }
    }
}
