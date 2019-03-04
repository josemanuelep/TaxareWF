using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Tecnomecanica
    {

        public int id { get; set; }
        public string placa { get; set; }
        public System.DateTime expedicion { get; set; }
        public System.DateTime vencimiento { get; set; }
        public Nullable<double> valor { get; set; }

        //Metodo constructor
        public Tecnomecanica(int id, string placa, DateTime expedicion, DateTime vencimiento, double? valor)
        {
            this.id = id;
            this.placa = placa;
            this.expedicion = expedicion;
            this.vencimiento = vencimiento;
            this.valor = valor;
        }
    }

}
