using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CambioAceite
    {
        public int id { get; set; }
        public string placaTaxi { get; set; }
        public string conductor { get; set; }
        public string tipoAceite { get; set; }
        public string taller { get; set; }
        public System.DateTime fecha { get; set; }
    }
}
