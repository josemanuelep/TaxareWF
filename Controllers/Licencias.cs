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
                BR.Licencias lic = new BR.Licencias(other.Numero_pase, conductorController.MostarIdConductor(other.conductor), transitoController.MostrarSecretaria(other.secretaria), other.categoria, other.expedicon, other.vencimiento);
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
            TextInfo myTI = CultureInfo.CurrentCulture.TextInfo;
            try
            {
                BR.Licencias other = db.Licencias.Where(x => x.Numero_pase == Numero).FirstOrDefault();
                EN.Licencias lic = new EN.Licencias(other.Numero_pase, other.Conductor.nombre.ToUpper() + " " + other.Conductor.apellido.ToUpper(), myTI.ToTitleCase(other.Secretarias_transito.localidad), other.categoria, other.expedicon,other.vencimiento);
                return lic;

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public List<EN.Licencias> mostrarLicencias() {

            var query = db.Licencias.ToList();
            List<EN.Licencias> lic = new List<EN.Licencias>();

            foreach (BR.Licencias other in query)
            {
                EN.Licencias licencia = new EN.Licencias(other.Numero_pase,other.Conductor.nombre.ToUpper(),other.Secretarias_transito.localidad,other.categoria,other.expedicon,other.vencimiento);
                lic.Add(licencia);
            }
            return lic;
        }
    }
}
