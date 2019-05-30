using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Inventario
    {

        public long id { get; set; }
        public string item { get; set; }
        public int cantidad { get; set; }
        public string descripcion { get; set; }

        //Metodo constructor
        public Inventario(long id, string item, int cantidad, string descripcion)
        {
            this.id = id;
            this.item = item;
            this.cantidad = cantidad;
            this.descripcion = descripcion;
        }
    }
}
