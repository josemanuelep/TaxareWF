using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxareProject.Controladores
{
    class ControladoraSS
    {
        db_taxareEntities1 db = new db_taxareEntities1();


        public bool Crear(SeguridadSocial other)
        {

            bool resultado = false;

            try
            {
                db.SeguridadSocials.Add(other);
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
                var d = db.SeguridadSocials.Where(x => x.id == id).FirstOrDefault();
                db.SeguridadSocials.Remove(d);
                db.SaveChanges();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }
 
        public bool Actualizar(SeguridadSocial other)
        {

            bool resultado = false;

            try
            {
                var d = db.SeguridadSocials.Where(x => x.id == other.id).FirstOrDefault();
                d.id_conductor = other.id_conductor;
                d.pago_anterior = other.pago_siguiente;
                d.pago_siguiente = other.pago_siguiente;
                db.SaveChanges();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }

        public List<SeguridadSocial> GetSocials() {

            return db.SeguridadSocials.ToList();
        }
    }
}
