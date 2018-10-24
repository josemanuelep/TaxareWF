using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxareProject.Controladores
{
    class ControladoraLicencias
    {
        db_taxareEntities1 db = new db_taxareEntities1();
        Licencia lic = new Licencia();

        public bool CrearLicencia(Licencia other)
        {
            bool resultado = false;


            try
            {

                db.Licencias.Add(other);
                db.SaveChanges();
                resultado = true;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return resultado;

        }

        public bool EliminarLicencia(int Numero)
        {
            bool resultado = false;
            try
            {

                lic = db.Licencias.Where(x => x.Numero_pase == Numero).FirstOrDefault();
                db.Licencias.Remove(lic);
                db.SaveChanges();
                resultado = true;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return resultado;
        }
        public bool ActualizarLicencia(Licencia other)
        {

            bool resultado = false;
            try
            {
                var lic = db.Licencias.Where(x => x.Numero_pase == other.Numero_pase).FirstOrDefault();
                lic.categoria = other.categoria;
                lic.id_conductor = other.id_conductor;
                lic.id_secretaria = other.id_secretaria;
                lic.expedicon = other.expedicon;
                lic.vencimiento = other.vencimiento;
                db.SaveChanges();
                resultado = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return resultado;

        }

        public Licencia MostarLicencia(int Numero)
        {

            try
            {
                return db.Licencias.Where(x => x.Numero_pase == Numero).FirstOrDefault();
                
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

    }
}



