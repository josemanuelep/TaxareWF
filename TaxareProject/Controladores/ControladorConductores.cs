using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxareProject.Controladores
{
    class ControladorConductores
    {

        db_taxareEntities db = new db_taxareEntities();
        Conductor conductor = new Conductor();

        public bool CrearConductor(Conductor conductor)
        {

            bool resultado = false;
            try
            {

                db.Conductors.Add(conductor);
                db.SaveChanges();
                resultado = true;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return resultado;
        }

        public bool EliminaConducor(int id)
        {

            bool resultado = false;
            try
            {
                conductor = db.Conductors.Where(x => x.id == id).FirstOrDefault();
                db.Conductors.Remove(conductor);
                db.SaveChanges();
                resultado = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return resultado;

        }

        public bool ActualizarConductor(Conductor conductorUpdate)
        {

            bool resultado = false;
            try
            {
                conductor = db.Conductors.Where(x => x.id == conductorUpdate.id).FirstOrDefault();
                db.SaveChanges();
                resultado = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return resultado;

        }
        public List<Conductor> MostrarConductores()
        {

            try
            {
                return db.Conductors.ToList<Conductor>();
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
        public Conductor MostarConductor(int cedula)
        {
            try
            {
                return  conductor = db.Conductors.Where(x => x.cedula == cedula).FirstOrDefault();
                
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        
    }
}
