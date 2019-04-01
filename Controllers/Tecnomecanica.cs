using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BR = Broker;
using EN = Entities;

namespace Controllers
{
    public class Tecnomecanica
    {
        //Entidad para la persistencia
        BR.taxareEntities db = new BR.taxareEntities();

        public bool Crear(EN.Tecnomecanica other)
        {

            bool resultado = false;

            try
            {
                //Mapeo de EN a BR
                BR.Tecnomecanica tec = new BR.Tecnomecanica(other.placa, other.expedicion, other.vencimiento, other.valor);
                //Insert en la bd
                db.Tecnomecanica.Add(tec);
                db.SaveChanges();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }

        public bool Actualizar(EN.Tecnomecanica other)
        {

            bool resultado = false;

            try
            {
                BR.Tecnomecanica update = db.Tecnomecanica.Where(x => x.id == other.id).FirstOrDefault();
                update.expedicion = other.expedicion;
                update.placa = other.placa;
                update.valor = other.valor;
                update.vencimiento = other.vencimiento;
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

                db.Tecnomecanica.Remove(db.Tecnomecanica.Where(x => x.id == id).FirstOrDefault());
                db.SaveChanges();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }

        public List<BR.Tecnomecanica> MostrarTecnomecanicas()
        {

            return db.Tecnomecanica.ToList();

        }

        public BR.Tecnomecanica MostrarTecnomecanica(int id)
        {

            return db.Tecnomecanica.Where(x => x.id == id).FirstOrDefault();

        }
    }
}
