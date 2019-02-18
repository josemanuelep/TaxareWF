using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BR = Broker;
using EN = Entities;

namespace Controllers
{
    public class Toperacion

    {

        BR.db_taxareEntities db = new BR.db_taxareEntities();

        public bool Crear(EN.Toperacion other)
        {

            bool resultado = false;

            try
            {
                db.Toperacion.Add(other);
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
                var elimininar = db.Toperacions.Where(x => x.id == id).FirstOrDefault();
                db.Toperacions.Remove(elimininar);
                db.SaveChanges();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }

        public bool Actualizar(Toperacion other)
        {

            bool resultado = false;

            try
            {
                var update = db.Toperacions.Where(x => x.id == other.id).FirstOrDefault();
                update.placa = other.placa;
                update.vencimiento = other.vencimiento;
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

        public Toperacion MostrarTO(int id)
        {

            return db.Toperacions.Where(x => x.id == id).FirstOrDefault();

        }
        public List<Toperacion> MostarTOs()
        {

            return db.Toperacions.ToList();

        }
    }
}
