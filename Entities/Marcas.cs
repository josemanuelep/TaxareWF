using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public  class Marcas
    {

        public int id { get; set; }
        public string marca { get; set; }

        public Marcas(int id, string marca)
        {
            this.id = id;
            this.marca = marca;
        }
    }
}
