using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxareProject.Querys
{
    class ProduccionxTaxis
    {
        public long id { get; set; }
        public string placa { get; set; }
        public string conductor { get; set; }
        public System.DateTime inicio { get; set; }
        public System.DateTime final { get; set; }
        public double valor { get; set; }
    }
}
