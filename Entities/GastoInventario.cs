using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class GastoInventario
    {

        public long id { get; set; }
        public string objinventario { get; set; }
        public string placaTaxi { get; set; }
        public int cantidadUsada { get; set; }
        public System.DateTime fecha { get; set; }

        public GastoInventario(long id, string objinventario, string placaTaxi, int cantidadUsada, DateTime fecha)
        {
            this.id = id;
            this.objinventario = objinventario;
            this.placaTaxi = placaTaxi;
            this.cantidadUsada = cantidadUsada;
            this.fecha = fecha;
        }

        //Metodo constructor

    }
}
