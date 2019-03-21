using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BR = Broker;
using EN = Entities;

namespace Controllers
{
    public class GastosVariables
    {
        BR.db_taxareEntities db = new BR.db_taxareEntities();

        public bool CrearGastoV(EN.GastosVariables other)
        {

            bool resultado = false;

            try
            {
                BR.GastosVariables gastoVariable = new BR.GastosVariables(other.placa, other.descripcion, other.fecha, other.kilometraje, other.valor);
                db.GastosVariables.Add(gastoVariable);
                db.SaveChanges();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }

        public bool EliminarGastoV(int id)
        {

            bool resultado = false;

            try
            {
                var delete = db.GastosVariables.Where(x => x.id == id).FirstOrDefault();
                db.GastosVariables.Remove(delete);
                db.SaveChanges();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }
        public bool ActualizarGastosV(EN.GastosVariables other)
        {

            bool resultado = false;

            try
            {

                var update = db.GastosVariables.Where(x => x.id == other.id).FirstOrDefault();
                update.descripcion = other.descripcion;
                update.fecha = other.fecha;
                update.kilometraje = other.kilometraje;
                update.placa = other.placa;
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

        public BR.GastosVariables DevuelveGV(int id)
        {

            return db.GastosVariables.Where(x => x.id == id).FirstOrDefault();

        }

        public List<BR.GastosVariables> gastosVariables()
        {

            return db.GastosVariables.ToList();
        }
    }
}

