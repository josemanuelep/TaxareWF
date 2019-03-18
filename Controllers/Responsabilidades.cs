using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BR = Broker;
using EN = Entities;

namespace Controllers
{
    public class Responsabilidades
    {
        BR.db_taxareEntities db = new BR.db_taxareEntities();

        public bool Crear(EN.Responsabilidades other)
        {

            bool resultado = false;

            try
            {
                //Mapeo
                BR.Responsabilidades res = new BR.Responsabilidades(other.placa, other.poliza, other.aseguradora, other.vencimiento, other.valor);
                //Insert bd
                db.Responsabilidades.Add(res);
                db.SaveChanges();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }

        public bool Actualizar(EN.Responsabilidades other)
        {

            bool resultado = false;

            try
            {
                BR.Responsabilidades update = db.Responsabilidades.Where(x => x.id == other.id).FirstOrDefault();
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
        public List<BR.Responsabilidades> MostarResponsabilidades()
        {

            return db.Responsabilidades.ToList<BR.Responsabilidades>();

        }
    }
}
