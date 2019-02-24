using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BR = Broker;
using EN = Entities;

namespace Controllers
{
   public  class Licencias
    {
        BR.db_taxareEntities db = new BR.db_taxareEntities();
        Conductores conductorController = new Conductores();
        Transito transitoController = new Transito();

        public bool CrearLicencia(EN.Licencias other)
        {
            bool resultado = false;


            try
            {
                //Mapeo
                BR.Licencias lic = new BR.Licencias();

                lic.categoria = other.categoria;
                lic.id_conductor = conductorController.MostarIdConductor(other.conductor);
                lic.expedicon = other.expedicon;
                lic.id_secretaria = transitoController.MostrarSecretaria(other.secretaria);
                lic.Numero_pase = other.Numero_pase;
                lic.vencimiento = other.vencimiento;

                db.Licencias.Add(lic);
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

                var lic = db.Licencias.Where(x => x.Numero_pase == Numero).FirstOrDefault();
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
        public bool ActualizarLicencia(EN.Licencias other)
        {

            bool resultado = false;
            try
            {
                var lic = db.Licencias.Where(x => x.Numero_pase == other.Numero_pase).FirstOrDefault();

                lic.categoria = other.categoria;
                lic.id_conductor = conductorController.MostarIdConductor(other.conductor);
                lic.expedicon = other.expedicon;
                lic.id_secretaria = transitoController.MostrarSecretaria(other.secretaria);
                lic.Numero_pase = other.Numero_pase;
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

        public EN.Licencias MostarLicencia(int Numero)
        {

            try
            {
                BR.Licencias other = db.Licencias.Where(x => x.Numero_pase == Numero).FirstOrDefault();
                EN.Licencias lic = new EN.Licencias();
                TextInfo myTI = CultureInfo.CurrentCulture.TextInfo;

                lic.categoria = other.categoria;
                lic.conductor = other.Conductor.nombre.ToUpper()+" "+other.Conductor.apellido.ToUpper();
                lic.expedicon = other.expedicon;
                lic.Numero_pase = other.Numero_pase;
                lic.secretaria = myTI.ToTitleCase(other.Secretarias_transito.localidad);
                lic.vencimiento = other.vencimiento;


                return lic;

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}
