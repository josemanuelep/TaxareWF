using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BR = Broker;

namespace Entities
{
    public class GananciasNetas
    {
        public string placa { get; set; }
        public System.DateTime inicio { get; set; }
        public System.DateTime final { get; set; }
        public List<Produccion> listaProducciones;
        public List<GastosVariables> listaGastos;
        public long totalGastos { get; set; }
        public long totalProduccion { get; set; }

        public GananciasNetas(string placa, DateTime inicio, DateTime final, List<Produccion> listaProducciones, List<GastosVariables> listaGastos, long totalGastos, long totalProduccion)
        {
            this.placa = placa;
            this.inicio = inicio;
            this.final = final;
            this.listaProducciones = listaProducciones;
            this.listaGastos = listaGastos;
            this.totalGastos = totalGastos;
            this.totalProduccion = totalProduccion;
        }

        public GananciasNetas()
        {
        }
    }
}
