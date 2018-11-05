
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxareProject.Controladores
{
    class ControladoraGastosVariablescs
    {
        db_taxareEntities1 db = new db_taxareEntities1();
        GastosVariable gasto = new GastosVariable();

        public bool CrearGastoV(GastosVariable other)
        {

            bool resultado = false;

            try
            {
                db.GastosVariables.Add(other);
                db.SaveChanges();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }

        public bool EliminarGastoV(GastosVariable other)
        {

            bool resultado = false;

            try
            {
                var delete = db.GastosVariables.Where(x => x.id == other.id).FirstOrDefault();
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
        public bool ActualizarGastosV(GastosVariable other)
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

        public GastosVariable DevuelveGV(int id)
        {

            return db.GastosVariables.Where(x => x.id == id).FirstOrDefault();

        }

        public List<GastosVariable> gastosVariables()
        {

            return db.GastosVariables.ToList();
        }
    }
}
