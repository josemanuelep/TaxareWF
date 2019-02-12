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
        BR.db_taxareEntities db = new BR.db_taxareEntities();
        //Controladores
        Marcas marcaController = new Marcas();
        Transito transitoController = new Transito();
        //Entidades para manipular las reglas del negocio
        EN.Taxis tx = new EN.Taxis();
        EN.Secretarias_transito sec = new EN.Secretarias_transito();
        EN.Marcas marca = new EN.Marcas();


        public bool CrearTaxi(EN.Taxis taxi)
        {
            BR.Taxis tx = new BR.Taxis();

            bool resultado = false;
            try
            {
                //Mapeo de clases
                tx.avaluo = taxi.avaluo;
                tx.cilindraje = taxi.cilindraje;
                tx.empresa_alfiliadora = tx.empresa_alfiliadora;
                tx.id_marca = marcaController.MostrarMarca(taxi.marca);
                tx.id_matricula = taxi.matricula;
                tx.id_transito = transitoController.MostrarSecretaria(taxi.transito);
                tx.modelo = taxi.modelo;
                tx.placa = taxi.placa;
             
                //Persistencia
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

        public List<BR.Taxis> MostrarTaxis()
        {

            try
            {
                return db.Taxis.ToList<BR.Taxis>();
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
        public BR.Taxis GetTaxi(string placa)
        {

            try
            {
                return db.Taxis.Where(x => x.placa == placa).FirstOrDefault();

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
