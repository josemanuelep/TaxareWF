using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BR = Broker;
using EN = Entities;

namespace Controllers
{
    public class GastosVariables
    {
        BR.taxareEntities db = new BR.taxareEntities();

        public bool CrearGastoV(EN.GastosVariables other)
        {

            bool resultado = false;

            try
            {
                BR.GastosVariables gastoVariable = new BR.GastosVariables(other.placa, other.descripcion, other.fecha, other.kilometraje, other.valor);
                db.GastosVariables.Add(gastoVariable);
                db.SaveChanges();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }

        public bool EliminarGastoV(int id)
        {

            bool resultado = false;

            try
            {
                var delete = db.GastosVariables.Where(x => x.id == id).FirstOrDefault();
                db.GastosVariables.Remove(delete);
                db.SaveChanges();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }
        public bool ActualizarGastosV(EN.GastosVariables other)
        {

            bool resultado = false;

            try
            {

                var update = db.GastosVariables.Where(x => x.id == other.id).FirstOrDefault();
                update.descripcion = other.descripcion;
                update.fecha = other.fecha;
                update.kilometraje = other.kilometraje;
                update.placa = other.placa;
                update.valor = other.valor;
                db.SaveChanges();
                resultado = true;

            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }

        public BR.GastosVariables DevuelveGV(int id)
        {

            return db.GastosVariables.Where(x => x.id == id).FirstOrDefault();

        }
        public List<BR.GastosVariables> GastosxAuto(string placa) {

            List<BR.GastosVariables> list = db.GastosVariables.Where(x=> x.placa == placa).ToList();

            if (list.Count()>0)
            {
                return list;
            }
            else {

                return null;
            }

        }

        public List<BR.GastosVariables> gastosVariables()
        {

            return db.GastosVariables.ToList();
        }
        public List<EN.GastosVariables> GastosporAutoRango(DateTime inicio, DateTime fin) {

            
            List<EN.GastosVariables> listaRetorno = new List<EN.GastosVariables>();
            List<BR.GastosVariables> query = db.GastosVariables.Where(x=>( x.fecha >= inicio && x.fecha <= fin)).ToList();
            Console.WriteLine(query.Count());
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
                }
                listaRetorno.Add(other);
            }

            return listaRetorno;
        }
        public List<EN.GastosVariables> GastosporAuto(DateTime desde)
        {

            List<EN.GastosVariables> listaRetorno = new List<EN.GastosVariables>();
            List<BR.GastosVariables> query = db.GastosVariables.Where(x=>x.fecha>= desde).ToList();

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
                    other.fecha = desde;
                    
                }
                listaRetorno.Add(other);
            }

            return listaRetorno;
        }
    }
}

