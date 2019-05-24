using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BR = Broker;
using EN = Entities;

namespace Controllers
{
    public class Soat
    {
        private BR.taxareEntities db;

        public Soat() {

            db = new BR.taxareEntities();
        }

        public bool Crear(EN.Soat other)
        {

            bool resultado = false;

            try
            {
                //Mapeo de EN a BR
                BR.Soat st = new BR.Soat(other.numero, other.placa_taxi, other.expedicion, other.expiracion, other.valor);
                //Insert en la bd
                db.Soat.Add(st);
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
                var delete = db.Soat.Where(x => x.id == id).FirstOrDefault();
                db.Soat.Remove(delete);
                db.SaveChanges();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }

        public bool Actualizar(EN.Soat other)
        {

            bool resultado = false;

            try
            {
                var u = db.Soat.Where(x => x.id == other.id).FirstOrDefault();
                //Update en la bd
                u.numero = other.numero;
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

        public List<BR.Soat> GetSoats()
        {

            return db.Soat.ToList<BR.Soat>();
        }

        public BR.Soat GetSoat(int id)
        {

            return db.Soat.Where(x => x.id == id).FirstOrDefault();
        }

        public BR.Soat GetSoatPorNumero(string numero)
        {

            return db.Soat.Where(x => x.numero == numero).FirstOrDefault();
        }

        public List<BR.Soat> ProximosVencer()
        {

            List<BR.Soat> ls = db.Soat.ToList<BR.Soat>();
            ls.Sort((x, y) => x.expiracion.CompareTo(y.expiracion));
            return ls;
        }
    }
}
