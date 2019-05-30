using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EN = Entities;
using BR = Broker;

namespace Controllers


{ 
    public class GananciasNetas
    {

        //Entidades para el manejo de la persistencia
        private BR.taxareEntities db;
        private Conductores conductoresController;
        private Taxis taxisController;
        private Produccion produccionController;
        private double totalGastos;
        private double totalProduccion;


        public GananciasNetas() {

            db = new BR.taxareEntities();
            conductoresController = new Conductores();
            taxisController = new Taxis();
            produccionController = new Produccion();
            


        }

        public EN.GananciasNetas obtenerGanancias(string placa, DateTime inicio, DateTime final)
        {
     
            try
            {
                EN.GananciasNetas ganancias = new EN.GananciasNetas();
                ganancias.listaGastos = this.GastosporAuto(placa, inicio, final);
                ganancias.listaProducciones = produccionController.produccionPlaca(placa, inicio, final);
                ganancias.inicio = inicio;
                ganancias.final = final;
                ganancias.placa = placa;
                ganancias.totalGastos = this.totalGastos;

                foreach (var item in produccionController.produccionPlaca(placa, inicio, final))
                {
                    this.totalProduccion = this.totalProduccion + item.producido;
                }
                ganancias.totalProduccion = this.totalProduccion;
                ganancias.neto = this.totalProduccion - totalGastos;
                return ganancias;
            }
            catch (Exception )
            {
              return null;

            }
           

        }


        public List<EN.GastosVariables> GastosporAuto(string placa,DateTime inicio, DateTime final)
        {

            List<EN.GastosVariables> listaRetorno = new List<EN.GastosVariables>();
            List<BR.GastosVariables> query = db.GastosVariables.Where(x => x.placa == placa && (x.fecha >= inicio.Date || x.fecha <= final.Date) ).ToList();

            //Group by query
            var resultado =
                from g in query
                group g by g.placa into gb
                select gb;

            //Recorrer la query
            foreach (var item in resultado)
            {
                EN.GastosVariables other = new EN.GastosVariables();
                other.placa = item.Key;

                //Recorre el list de gastos porque es una clausua groupBy
                foreach (var gasto in item)
                {
                    other.kilometraje = gasto.kilometraje;
                    other.totalGastos += gasto.valor;
                    other.numeroGastos = item.Count();
                    other.fecha = gasto.fecha;

                }
                this.totalGastos = other.totalGastos;
                listaRetorno.Add(other);
            }

            return listaRetorno;
        }

    }
}
