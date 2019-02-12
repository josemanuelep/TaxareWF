using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Taxis
    {
        public string placa { get; set; }
        public int id_matricula { get; set; }
        public int id_transito { get; set; }
        public int id_marca { get; set; }
        public int modelo { get; set; }
        public int cilindraje { get; set; }
        public string empresa_alfiliadora { get; set; }
        public int avaluo { get; set; }
    }
}
