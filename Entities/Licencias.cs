using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Licencias
    {
        public long Numero_pase { get; set; }
        public string conductor { get; set; }
        public string secretaria { get; set; }
        public string categoria { get; set; }
        public System.DateTime expedicon { get; set; }
        public System.DateTime vencimiento { get; set; }

        public Licencias(long numero_pase, string conductor, string secretaria, string categoria, DateTime expedicon, DateTime vencimiento)
        {
            Numero_pase = numero_pase;
            this.conductor = conductor;
            this.secretaria = secretaria;
            this.categoria = categoria;
            this.expedicon = expedicon;
            this.vencimiento = vencimiento;
        }
    }
}
