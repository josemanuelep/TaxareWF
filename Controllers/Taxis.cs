using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BR = Broker;
using EN = Entities;

namespace Controllers
{
    public class Taxis
    {
        //Conexion a la base de datos
        BR.taxareEntities db = new BR.taxareEntities();
        //Controladores
        Marcas marcaController = new Marcas();
        Transito transitoController = new Transito();
    

        public bool CrearTaxi(EN.Taxis taxi)
        {
            

            bool resultado = false;
            try
            {
                //Mapeo de clases
                BR.Taxis tx = new BR.Taxis(taxi.placa, taxi.matricula, transitoController.MostrarSecretaria(taxi.transito), marcaController.MostrarMarca(taxi.marca),taxi.modelo, taxi.cilindraje, taxi.empresa_alfiliadora, taxi.avaluo);
                tx.avaluo = taxi.avaluo;
                tx.id_matricula = taxi.matricula;
                db.Taxis.Add(tx);
                db.SaveChanges();
                resultado = true;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return resultado;
        }

        public bool EliminarTaxi(string txplaca)
        {

            bool resultado = false;
            try
            {
                BR.Taxis tx = db.Taxis.Where(x => x.placa == txplaca).FirstOrDefault();
                db.Taxis.Remove(tx);
                db.SaveChanges();
                resultado = true;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            return resultado;

        }

        public bool ActualizarTaxi(EN.Taxis taxi_update)
        {

            bool resultado = false;
            try
            {
                    //Busqueda de la entidad en la BD
                    BR.Taxis tax = db.Taxis.Where(x => x.placa == taxi_update.placa).FirstOrDefault();
                    //Cambios sobre la entidad de persistencia
                    tax.id_matricula = taxi_update.matricula;
                    tax.id_transito = transitoController.MostrarSecretaria(taxi_update.transito); 
                    tax.id_marca = marcaController.MostrarMarca(taxi_update.marca);
                    tax.modelo = taxi_update.modelo;
                    tax.cilindraje = taxi_update.cilindraje;
                    tax.empresa_alfiliadora = taxi_update.empresa_alfiliadora;
                    tax.avaluo = taxi_update.avaluo;
                    db.SaveChanges();
                    resultado = true;

                

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return resultado;

        }

        public List<EN.Taxis> MostrarTaxis()
        {
            List<EN.Taxis> txs = new List<EN.Taxis>();
            try
            {
                var query = db.Taxis.ToList<BR.Taxis>();

                foreach (var other in query)
                {
                    EN.Taxis car = new EN.Taxis(other.placa,other.id_matricula,other.Secretarias_transito.localidad, marcaController.MostrarMarca_String(other.id_marca),other.modelo,other.cilindraje,other.empresa_alfiliadora,other.avaluo);
                    txs.Add(car);
                }
                return txs;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
        public EN.Taxis GetTaxi(string placa)
        {

            try
            {
                var query = db.Taxis.Where(x => x.placa == placa).FirstOrDefault();
                EN.Taxis taxiReturn = new EN.Taxis(query.placa, query.id_matricula, query.Secretarias_transito.localidad.ToUpper(), query.Marcas.marca, query.modelo, query.cilindraje, query.empresa_alfiliadora, query.avaluo);
                return taxiReturn;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public int NumeroTaxis()
        {

            var list = db.Taxis.Count();
            return Convert.ToInt16(list);
        }

        public BR.Taxis MaxTax()
        {

            IList<BR.Taxis> list = db.Taxis.ToList<BR.Taxis>();

            return list.Max();

        }
    }
}
