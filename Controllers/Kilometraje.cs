using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BR = Broker;
using EN = Entities;

namespace Controllers
{
    public class Kilometraje
    {
        BR.db_taxareEntities db = new BR.db_taxareEntities();

        public bool crearKilometraje(EN.Kilometrajes other)
        {


            bool resultado = false;

            try
            {
                BR.Kilometrajes kms = new BR.Kilometrajes();

                kms.fecha = other.fecha;
                kms.kilometraje = other.kilometraje;
                kms.placa = other.placa;

                db.Kilometrajes.Add(kms);
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
                var kms = db.Kilometrajes.Where(x => x.id == id).FirstOrDefault();
                db.Kilometrajes.Remove(kms);
                db.SaveChanges();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }

        public bool ActualizarKilometraje(EN.Kilometrajes other)
        {
            bool resultado = false;

            try
            {
                var update = db.Kilometrajes.Where(x => x.id == other.id).FirstOrDefault();

                update.fecha = other.fecha;
                update.kilometraje = other.kilometraje;
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
        public bool ActualizarKilometraje(String placa, double kms)
        {
            bool resultado = false;

            try
            {
                var update = db.Kilometrajes.Where(x => x.placa == placa).FirstOrDefault();
                update.kilometraje = kms;
                db.SaveChanges();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;

        }

        public EN.Kilometrajes ObtenerKilometraje(long id)
        {


            try
            {
                var kms = db.Kilometrajes.Where(x => x.id == id).FirstOrDefault();
                EN.Kilometrajes k = new EN.Kilometrajes();

                k.fecha = kms.fecha;
                k.id = kms.id;
                k.kilometraje = kms.kilometraje;
                k.placa = kms.placa;
                
                return k;

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
                var k = db.Kilometrajes.Where(x => x.placa == placa).FirstOrDefault();
                return k.id;

            }
            catch (Exception)
            {

                throw;
            }

        }
        public List<BR.Kilometrajes> ObtenerKilometrajes()
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
