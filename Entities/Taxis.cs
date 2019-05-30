using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Taxis
    {


        public string placa { get; set; }
        public int matricula { get; set; }
        public string transito { get; set; }
        public string marca { get; set; }
        public int modelo { get; set; }
        public int cilindraje { get; set; }
        public string empresa_alfiliadora { get; set; }
        public int avaluo { get; set; }

        //Metodo constructor


        public Taxis(string placa, int matricula, string transito, string marca, int modelo, int cilindraje, string empresa_alfiliadora, int avaluo)
        {
            this.placa = placa;
            this.matricula = matricula;
            this.transito = transito;
            this.marca = marca;
            this.modelo = modelo;
            this.cilindraje = cilindraje;
            this.empresa_alfiliadora = empresa_alfiliadora;
            this.avaluo = avaluo;
        }

        public Taxis()
        {
        }
    }
}
