using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class GastosVariables
    {

        public int id { get; set; }
        public string placa { get; set; }
        public string descripcion { get; set; }
        public System.DateTime fecha { get; set; }
        public double kilometraje { get; set; }
        public double valor { get; set; }

        //Metodo constructor
        public GastosVariables(int id, string placa, string descripcion, DateTime fecha, double kilometraje, double valor)
        {
            this.id = id;
            this.placa = placa;
            this.descripcion = descripcion;
            this.fecha = fecha;
            this.kilometraje = kilometraje;
            this.valor = valor;
        }

        public GastosVariables()
        {
        }

        public override string ToString()
        {
            return id + " " + placa + " " + descripcion + " " + fecha + " " + kilometraje + " " + valor;
        }

    }
}
