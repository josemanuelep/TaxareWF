using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Toperacion
    {

        public int id { get; set; }
        public string placa { get; set; }
        public System.DateTime vencimiento { get; set; }
        public double valor { get; set; }
        //Metodo constructor
        public Toperacion(int id, string placa, DateTime vencimiento, double valor)
        {
            this.id = id;
            this.placa = placa;
            this.vencimiento = vencimiento;
            this.valor = valor;
        }

        public Toperacion(){}

    }
}
