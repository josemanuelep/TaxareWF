using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxareProject.Controladores
{
    class ControladoraResponsabilidades
    {
        db_taxareEntities1 db = new db_taxareEntities1();
        Responsabilidade res = new Responsabilidade();

        public bool Crear(Responsabilidade other)
        {

            bool resultado = false;

            try
            {
                db.Responsabilidades.Add(other);
                db.SaveChanges();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }

        public bool Actualizar(Responsabilidade other)
        {

            bool resultado = false;

            try
            {
                var update = db.Responsabilidades.Where(x => x.id == other.id).FirstOrDefault();
                update.placa = other.placa;
                update.poliza = other.poliza;
                update.aseguradora = other.aseguradora;
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


        public bool Eliminar(int id)
        {

            bool resultado = false;

            try
            {
                var delete = db.Responsabilidades.Where(x => x.id == id).FirstOrDefault();
                db.Responsabilidades.Remove(delete);
                db.SaveChanges();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }
        public List<Responsabilidade> MostarResponsabilidades()
        {

            return db.Responsabilidades.ToList();

        }
    }
}
