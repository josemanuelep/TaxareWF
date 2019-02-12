using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Licencias
    {
        public long Numero_pase { get; set; }
        public long id_conductor { get; set; }
        public int id_secretaria { get; set; }
        public string categoria { get; set; }
        public System.DateTime expedicon { get; set; }
        public System.DateTime vencimiento { get; set; }
    }
}
