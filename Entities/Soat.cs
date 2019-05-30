using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Soat
    {
        public int id { get; set; }
        public string numero { get; set; }
        public string placa_taxi { get; set; }
        public DateTime expedicion { get; set; }
        public DateTime expiracion { get; set; }
        public string valor { get; set; }

        public Soat()
        {
        }

        //Metodo constructor
        public Soat(string numero, string placa_taxi, DateTime expedicion, DateTime expiracion, string valor)
        {
   
            this.numero = numero;
            this.placa_taxi = placa_taxi;
            this.expedicion = expedicion;
            this.expiracion = expiracion;
            this.valor = valor;
        }
    }
}
