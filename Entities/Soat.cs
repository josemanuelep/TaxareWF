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
        public string expedicion { get; set; }
        public string expiracion { get; set; }
        public string valor { get; set; }

        //Metodo constructor
        public Soat(int id, string numero, string placa_taxi, string expedicion, string expiracion, string valor)
        {
            this.id = id;
            this.numero = numero;
            this.placa_taxi = placa_taxi;
            this.expedicion = expedicion;
            this.expiracion = expiracion;
            this.valor = valor;
        }
    }
}
