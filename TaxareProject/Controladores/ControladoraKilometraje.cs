using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxareProject.Controladores
{
    class ControladoraKilometraje
    {
        db_taxareEntities1 db = new db_taxareEntities1();
        Kilometraje kilo = new Kilometraje();

        public bool crearKilometraje(Kilometraje other)
        {


            bool resultado = false;

            try
            {
                db.Kilometrajes.Add(other);
                db.SaveChanges();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }

        public bool eliminarKilometraje(long id)
        {

            bool resultado = false;

            try
            {
                kilo = db.Kilometrajes.Where(x => x.id == id).FirstOrDefault();
                db.Kilometrajes.Remove(kilo);
                db.SaveChanges();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }

        public bool ActualizarKilometraje(Kilometraje other)
        {
            bool resultado = false;

            try
            {
                var update = db.Kilometrajes.Where(x => x.id == other.id).FirstOrDefault();
                update.fecha = other.fecha;
                update.kilometraje1 = other.kilometraje1;
                update.placa = other.placa;
                db.SaveChanges();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;

        }

        public Kilometraje ObtenerKilometraje(long id)
        {


            try
            {
                kilo = db.Kilometrajes.Where(x => x.id == id).FirstOrDefault();
                return kilo;

            }
            catch (Exception)
            {

                throw;
            }

        }

        public long ObtenerIDKilometraje(String placa)
        {


            try
            {
                kilo = db.Kilometrajes.Where(x => x.placa == placa).FirstOrDefault();
                return kilo.id;

            }
            catch (Exception)
            {

                throw;
            }

        }
        public List<Kilometraje> ObtenerKilometrajes()
        {

            try
            {
                return db.Kilometrajes.ToList(); ;

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
