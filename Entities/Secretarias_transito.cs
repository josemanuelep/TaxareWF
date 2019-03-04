using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Secretarias_transito
    {

        public int id { get; set; }
        public string localidad { get; set; }

        //Metodo Constructor
        public Secretarias_transito(int id, string localidad)
        {
            this.id = id;
            this.localidad = localidad;
        }
    }
}
