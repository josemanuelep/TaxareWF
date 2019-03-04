using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class GastosFijos
    {
        public long id { get; set; }
        public string gasto { get; set; }
        public bool estaPago { get; set; }

        //Metodo constructor
        public GastosFijos(long id, string gasto, bool estaPago)
        {
            this.id = id;
            this.gasto = gasto;
            this.estaPago = estaPago;
        }
    }
}
