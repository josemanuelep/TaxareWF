using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxareProject.Controladores
{
    class ControladorTaxis
    {
        db_taxareEntities1 db = new db_taxareEntities1();
        Taxi tx = new Taxi();
        Secretarias_transito sec = new Secretarias_transito();
        Marca mr = new Marca();

       
        public bool CrearTaxi(Taxi taxi)
        {

            bool resultado = false;
            try
            {

                db.Taxis.Add(taxi);
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
                tx = db.Taxis.Where(x => x.placa == txplaca).FirstOrDefault();
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

        public bool ActualizarTaxi(Taxi taxi_update)
        {

            bool resultado = false;
            try
            {
                using (var context = new db_taxareEntities1())
                {
                    var tax = context.Taxis.Where(x => x.placa == taxi_update.placa).FirstOrDefault();
                    tax.id_matricula = taxi_update.id_matricula;
                    tax.id_transito = taxi_update.id_transito;
                    tax.id_marca = taxi_update.id_marca;
                    tax.modelo = taxi_update.modelo;
                    tax.cilindraje = taxi_update.cilindraje;
                    tax.empresa_alfiliadora = taxi_update.empresa_alfiliadora;
                    tax.avaluo = taxi_update.avaluo;
                    context.SaveChanges();
                    resultado = true;

                }
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return resultado;

        }

        public List<Taxi> MostrarTaxis()
        {

            try
            {
                return db.Taxis.ToList<Taxi>();
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
        public Taxi GetTaxi(string placa) {

            try
            {
                 return tx = db.Taxis.Where(x => x.placa == placa).FirstOrDefault();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ese Taxi no esta registrado");
                throw ex;
            }

        }

        public int NumeroTaxis() {

            var list = db.Taxis.Count();
            return Convert.ToInt16(list); 
        }

        public Taxi MaxTax() {

            IList<Taxi> list = db.Taxis.ToList<Taxi>();

            return list.Max();
           
        }
    }
}
