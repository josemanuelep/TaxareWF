using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Kilometrajes
    {

        public long id { get; set; }
        public string placa { get; set; }
        public double kilometraje { get; set; }
        public System.DateTime fecha { get; set; }

        //Metodo Constructor
        public Kilometrajes(long id, string placa, double kilometraje, DateTime fecha)
        {
            this.id = id;
            this.placa = placa;
            this.kilometraje = kilometraje;
            this.fecha = fecha;
        }
    }
}
