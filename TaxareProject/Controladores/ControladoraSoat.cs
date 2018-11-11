using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxareProject.Controladores
{
    class ControladoraSoat
    {
        db_taxareEntities1 db = new db_taxareEntities1();

        public bool Crear(Soat other)
        {

            bool resultado = false;

            try
            {
                db.Soats.Add(other);
                db.SaveChanges();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }

        public bool Eliminar(int id)
        {

            bool resultado = false;

            try
            {
                var delete = db.Soats.Where(x => x.id == id).FirstOrDefault();
                db.Soats.Remove(delete);
                db.SaveChanges();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }

        public bool Actualizar(Soat other)
        {

            bool resultado = false;

            try
            {
                var u = db.Soats.Where(x => x.id == other.id).FirstOrDefault();
                //u.numero = other.numero;
                u.placa_taxi = other.placa_taxi;
                u.expedicion = other.expedicion;
                u.expiracion = other.expiracion;
                u.valor = other.valor;
                db.SaveChanges();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }

        public List<Soat> GetSoats() {

            return db.Soats.ToList<Soat>();
        }

        public Soat GetSoat(int id) {

            return db.Soats.Where(x => x.id == id).FirstOrDefault();
        }
    }

}
