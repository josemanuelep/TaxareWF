using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BR = Broker;
using EN = Entities;
namespace Controllers
{
    public class Produccion
    {

        //Entidades para el manejo de la persistencia
        BR.taxareEntities db;
        Conductores conductoresController;
        Taxis taxisController;

        public Produccion()
        {

            db = new BR.taxareEntities();
            conductoresController = new Conductores();
            taxisController = new Taxis();
        }

        public bool CrearProduccion(BR.Produccion produccion) {

            bool resultado = false;

            try
            {
     
                db.Produccion.Add(produccion);
                db.SaveChanges();
                resultado = true;

                return resultado;
            }
            catch (Exception ex)
            {
                throw ex;
                
            }

            

        }

        public bool ActualzarProduccion(BR.Produccion produccion)
        {

            bool resultado = false;

            try
            {
                BR.Produccion actualizar = db.Produccion.Where(x=>x.id == produccion.id).FirstOrDefault();
                actualizar.final = produccion.final;
                actualizar.id_taxista = produccion.id_taxista;
                actualizar.inicio = produccion.inicio;
                actualizar.placa = produccion.placa;
                actualizar.valor = produccion.valor;
                db.SaveChanges();

                resultado = true;
                return resultado;
            }
            catch (Exception)
            {
                return resultado;
                throw;
            }



        }

        public bool EliminarProduccrion(int idaEliminar)
        {

            bool resultado = false;
            try
            {

               
                BR.Produccion eliminar = db.Produccion.Where(x => x.id == idaEliminar).FirstOrDefault();
                db.Produccion.Remove(eliminar);
                db.SaveChanges();
           
                return resultado;
            }
            catch (Exception)
            {
                return resultado;

            }

        }

        public EN.Produccion ObtenerProduccionPorId(int id)
        {

            try
            {

                EN.Produccion entidad = new EN.Produccion();
                BR.Produccion obtenida = db.Produccion.Where(x => x.id == id).FirstOrDefault();
                //Mapeo clase a clase
                // Difference in days, hours, and minutes.
                TimeSpan ts = obtenida.final-obtenida.inicio;
                int dias = ts.Days+1; 
                entidad.conductor = conductoresController.MostarConductor(obtenida.id_taxista).nombre;
                entidad.dias = dias;
                entidad.final = obtenida.final;
                entidad.id = obtenida.id;
                entidad.inicio = obtenida.inicio;
                entidad.placa = obtenida.placa;
                entidad.producido = obtenida.valor;

                return entidad;
            }
            catch (Exception)
            {
                return null;
               
            }

        }

        public List<EN.Produccion> ListaProducciones() {

            List<EN.Produccion> toReturn = new List<EN.Produccion>();

            var query = db.Produccion.ToList();

            foreach (var item in query)
            {
                EN.Produccion entidad = new EN.Produccion();
                //Mapeo clase a clase
                // Difference in days, hours, and minutes.
                TimeSpan ts = item.final - item.inicio;
                var conductor = conductoresController.MostarConductor(item.id_taxista);
                int dias = ts.Days;
                entidad.conductor = conductor.nombre + " " + conductor.apellido;
                entidad.dias = dias;
                entidad.final = item.final;
                entidad.id = item.id;
                entidad.inicio = item.inicio;
                entidad.placa = item.placa;
                entidad.producido = item.valor;

                toReturn.Add(entidad);

            }

            return toReturn;

        }


        public EN.Produccion produccionxPlaca(string placa, DateTime ini, DateTime final)
        {


            var query = db.Produccion.Where(x=>x.placa == placa && x.inicio >= ini && x.final <= final).ToList();

            EN.Produccion entidad = new EN.Produccion();
            TimeSpan ts = final - ini;
            int dias = ts.Days;
            entidad.dias = dias;
            entidad.placa = placa;
            entidad.inicio = ini;
            entidad.final = final;

            double total = 0;

            foreach (var item in query)
            {

                total += item.valor;

            }
            entidad.producido = total;

            return entidad;

        }


        public EN.Produccion produccionxTaxista(int id, DateTime ini, DateTime final)
        {


            var query = db.Produccion.Where(x => x.id_taxista == id).ToList();

            EN.Produccion entidad = new EN.Produccion();
            TimeSpan ts = final - ini;
            int dias = ts.Days;
            entidad.conductor = conductoresController.MostarConductor(id).nombre.ToUpper();
            entidad.dias = dias;
            

            double total = 0;

            foreach (var item in query)
            {
                entidad.placa = item.placa;
                total += item.valor;

            }

            return entidad;

        }

        public List<EN.Produccion> produccionPlaca(string placa) {

            List<EN.Produccion> toReturn = new List<EN.Produccion>();

            var query = db.Produccion.Where(x => x.placa == placa).ToList();
            foreach (var item in query)
            {
                EN.Produccion entidad = new EN.Produccion();
                //Mapeo clase a clase
                // Difference in days, hours, and minutes.
                TimeSpan ts = item.final - item.inicio;
                var conductor = conductoresController.MostarConductor(item.id_taxista);
                int dias = ts.Days;
                entidad.conductor = conductor.nombre + " " + conductor.apellido;
                entidad.dias = dias;
                entidad.final = item.final;
                entidad.id = item.id;
                entidad.inicio = item.inicio;
                entidad.placa = item.placa;
                entidad.producido = item.valor;

                toReturn.Add(entidad);

            }

            return toReturn;

        }

    }
}
