using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Tecnomecanica
    {

        public int id { get; set; }
        public string placa { get; set; }
        public System.DateTime expedicion { get; set; }
        public System.DateTime vencimiento { get; set; }
        public Nullable<double> valor { get; set; }
    }
}
