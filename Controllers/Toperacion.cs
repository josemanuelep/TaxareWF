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
        //Entidades para el manejo de la persistencia
        BR.db_taxareEntities db = new BR.db_taxareEntities();

        public bool Crear(EN.Toperacion other)
        {

            bool resultado = false;

            try
            {
                //Mapeo de entidad del negocio a la entidad de persistencia
                BR.Toperacion top = new BR.Toperacion(other.placa, other.vencimiento, other.valor);
                //Insert en la bd
                db.Toperacion.Add(top);
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
            {   //Delete en la bd
                db.Toperacion.Remove(db.Toperacion.Where(x => x.id == id).FirstOrDefault());
                db.SaveChanges();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }

        public bool Actualizar(EN.Toperacion other)
        {

            bool resultado = false;

            try
            {
                BR.Toperacion update = db.Toperacion.Where(x => x.id == other.id).FirstOrDefault();
                //Update en la bd
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

        public EN.Toperacion MostrarTO(int id)
        {
            EN.Toperacion top = new EN.Toperacion();
            //Select de la bd
            var other = db.Toperacion.Where(x => x.id == id).FirstOrDefault();
            top.id= other.id;
            top.placa = other.placa;
            top.valor = other.valor;
            top.vencimiento = other.vencimiento;
            return top;

        }
        public List<BR.Toperacion> MostarTOs()
        {

            return db.Toperacion.ToList<BR.Toperacion>();

        }
    }
}
