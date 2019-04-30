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
        BR.taxareEntities db = new BR.taxareEntities();
        Conductores conductorController = new Conductores();
        Transito transitoController = new Transito();

        public bool CrearLicencia(BR.Licencias other)
        {
            bool resultado = false;
            try
            {
                //Mapeo
                BR.Licencias lic = new BR.Licencias(other.Numero_pase,other.id_conductor, other.id_secretaria, other.categoria, other.expedicon, other.vencimiento);
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
                if (other != null)
                {
                    EN.Licencias lic = new EN.Licencias(other.Numero_pase, other.Conductor.nombre.ToUpper() + " " + other.Conductor.apellido.ToUpper(), myTI.ToTitleCase(other.Secretarias_transito.localidad), other.categoria, other.expedicon, other.vencimiento);
                    return lic;
                }
                else
                    return null;

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public EN.Licencias MostarLicenciaPorNombre(string nombre)
        {
            TextInfo myTI = CultureInfo.CurrentCulture.TextInfo;
            try
            {
                var conductor = db.Conductor.Where(x => x.nombre.Contains(nombre)).FirstOrDefault();

                if (conductor != null)
                {
                    BR.Licencias other = db.Licencias.Where(x => x.id_conductor == conductor.id).FirstOrDefault();
                    EN.Licencias lic = new EN.Licencias(other.Numero_pase, other.Conductor.nombre.ToUpper() + " " + other.Conductor.apellido.ToUpper(), myTI.ToTitleCase(other.Secretarias_transito.localidad), other.categoria, other.expedicon, other.vencimiento);
                    lic.cedula = other.Conductor.cedula;
                    return lic;
                }

                return null;

            }
            catch (Exception)
            {

                throw null;
            }

        }
        public List<EN.Licencias> mostrarLicencias() {

            List<BR.Licencias> query = db.Licencias.ToList();
            List<EN.Licencias> lic = new List<EN.Licencias>();

            foreach (BR.Licencias other in query)
            {
                EN.Licencias licencia = new EN.Licencias();
                licencia.Numero_pase = other.Numero_pase;
                licencia.conductor = other.Conductor.nombre.ToUpper();
                licencia.secretaria = other.Secretarias_transito.localidad;
                licencia.categoria = other.categoria;
                licencia.expedicon = other.expedicon;
                other.vencimiento = other.vencimiento;
                lic.Add(licencia);
                
            }
            return lic;
        }

        public int numeroLincecias() {

            return db.Licencias.ToList().Count();
        }

        public List<EN.Licencias> licenciasVencidas() {

            DateTime dateTime = DateTime.Today.Date;
            List<BR.Licencias> query = db.Licencias.Where(x=>x.vencimiento >= dateTime).ToList();
            List<EN.Licencias> lic = new List<EN.Licencias>();

            foreach (BR.Licencias other in query)
            {
                EN.Licencias licencia = new EN.Licencias(other.Numero_pase, other.Conductor.nombre.ToUpper(), other.Secretarias_transito.localidad, other.categoria, other.expedicon, other.vencimiento);
                lic.Add(licencia);

            }
            return lic;

        }

        public List<BR.Conductor> conductoresSinLicencia() {

            List<BR.Conductor> d = db.Conductor.ToList();
            var query = db.Licencias.ToList();
            foreach (var item in query)
            {
                d.RemoveAll(x=>x.id == item.id_conductor);
                
            }
            return d;
        }
    }
}
