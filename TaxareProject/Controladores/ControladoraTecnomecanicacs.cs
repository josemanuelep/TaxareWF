using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxareProject.Controladores
{
    class ControladoraTecnomecanicacs
    {
        db_taxareEntities1 db = new db_taxareEntities1();

        public bool Crear(Tecnomecanica other)
        {

            bool resultado = false;

            try
            {
                db.Tecnomecanicas.Add(other);
                db.SaveChanges();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }

        public bool Actualizar(Tecnomecanica other)
        {

            bool resultado = false;

            try
            {
                var update = db.Tecnomecanicas.Where(x => x.id == other.id).FirstOrDefault();
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
                var delete = db.Tecnomecanicas.Where(x => x.id == id).FirstOrDefault();
                db.Tecnomecanicas.Remove(delete);
                db.SaveChanges();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }

        public List<Tecnomecanica> MostrarTecnomecanicas()
        {

            return db.Tecnomecanicas.ToList();

        }

        public Tecnomecanica MostrarTecnomecanica(int id)
        {

            return db.Tecnomecanicas.Where(x => x.id == id).FirstOrDefault();

        }
    }
}
