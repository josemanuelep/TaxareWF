using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Responsabilidades
    {
        public int id { get; set; }
        public string placa { get; set; }
        public int poliza { get; set; }
        public string aseguradora { get; set; }
        public System.DateTime vencimiento { get; set; }
        public double valor { get; set; }

        //Metodo Constructor
        public Responsabilidades(int id, string placa, int poliza, string aseguradora, DateTime vencimiento, double valor)
        {
            this.id = id;
            this.placa = placa;
            this.poliza = poliza;
            this.aseguradora = aseguradora;
            this.vencimiento = vencimiento;
            this.valor = valor;
        }
    }
}
