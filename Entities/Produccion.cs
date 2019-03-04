using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Produccion
    {

        public long id { get; set; }
        public Nullable<long> idTurno { get; set; }
        public double producido { get; set; }
        public string placa  { get; set; }
        public string conductor { get; set; }
        public int dias { get; set; }

        //Metodo Constructor
        public Produccion(long id, long? idTurno, double producido, string placa, string conductor, int dias)
        {
            this.id = id;
            this.idTurno = idTurno;
            this.producido = producido;
            this.placa = placa;
            this.conductor = conductor;
            this.dias = dias;
        }
    }
}
