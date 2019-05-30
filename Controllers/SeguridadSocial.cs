using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BR = Broker;
using EN = Entities;

namespace Controllers
{
    public class SeguridadSocial
    {
        //Entidad para la persistencia
        BR.taxareEntities db = new BR.taxareEntities();

        //Entidad de controladora de conductores para annadir un conductor y hallar la FK
        Conductores conductoresController = new Conductores();

        public bool Crear(EN.SeguridadSocial other, string cedula)
        {

            bool resultado = false;

            try
            {
                //Mapeo de EN BR
                BR.SeguridadSocial ss = new BR.SeguridadSocial(conductoresController.MostarIdConductor(cedula), other.pago_anterior, other.pago_siguiente, other.valor);
                //Inserte en la bd
                db.SeguridadSocial.Add(ss);
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
                db.SeguridadSocial.Remove(db.SeguridadSocial.Where(x => x.id == id).FirstOrDefault());
                db.SaveChanges();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }

        public bool Actualizar(EN.SeguridadSocial other, string cedula)
        {

            bool resultado = false;

            try
            {
                //Select bd
                var d = db.SeguridadSocial.Where(x => x.id == other.id).FirstOrDefault();
                //Update bd
                if (cedula.Length>0)
                {
                    d.id_conductor = conductoresController.MostarIdConductor(cedula);
                }
                d.pago_anterior = other.pago_siguiente;
                d.pago_siguiente = other.pago_siguiente;
                d.valor = other.valor;
                db.SaveChanges();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }

        public List<EN.SeguridadSocial> GetSocials()
        {
            List<EN.SeguridadSocial> list = new List<EN.SeguridadSocial>();
            var query = db.SeguridadSocial.ToList();

            foreach (BR.SeguridadSocial other in  query)
            {
                EN.SeguridadSocial ss = new EN.SeguridadSocial();
                ss.conductor = conductoresController.MostarConductor(other.id_conductor).nombre.ToUpper();
                ss.id = other.id;
                ss.pago_anterior = other.pago_anterior;
                ss.pago_siguiente = other.pago_siguiente;
                ss.valor = other.valor;
                list.Add(ss);
            }
            return list ;
        }


        public bool esta(int id) {

            var query = db.SeguridadSocial.Where(x=>x.id_conductor == id).ToList();

            if (query.Count==0)
            {
                return false;
            }
            else {

                return true;
            }

        }

        public EN.SeguridadSocial GetSocial(int id)
        {
            
            var other = db.SeguridadSocial.Where(x => x.id == id).FirstOrDefault();

            //Mapeo
            EN.SeguridadSocial ss = new EN.SeguridadSocial(other.id, other.Conductor.nombre.ToUpper() + " " + other.Conductor.apellido.ToUpper(), other.pago_anterior, other.pago_siguiente, other.valor);
            
            return ss;
        }


        public BR.SeguridadSocial GetSocial(int id, bool a)
        {

            var other = db.SeguridadSocial.Where(x => x.id == id).FirstOrDefault();
            return other;
        }


        public Double SumaTotal()
        {
            System.Nullable<Double> totalFreight = (from p in db.SeguridadSocial select p.valor).Sum();

            return Convert.ToDouble(totalFreight);

        }

        public List<EN.SeguridadSocial> VencenDosDias()
        {

            List<EN.SeguridadSocial> sc = new List<EN.SeguridadSocial>();

            DateTime dias = new DateTime();
            dias.AddDays(2);

            var q = db.SeguridadSocial.Where(x => x.pago_siguiente == dias).ToList();

            foreach (var other in q)
            {
                EN.SeguridadSocial sss = new EN.SeguridadSocial();
                sss.id = other.id;
                sss.pago_siguiente = other.pago_siguiente;
                sss.conductor = other.Conductor.nombre.ToUpper();
                sc.Add(sss);

            }

            return sc;

        }

        public List<EN.SeguridadSocial> Vencidos()
        {
            List<EN.SeguridadSocial> sc = new List<EN.SeguridadSocial>();

            DateTime dias = new DateTime();
            dias = DateTime.Today;

            var q = db.SeguridadSocial.Where(x => x.pago_siguiente <= dias).ToList();

            foreach (var other in q)
            {
                EN.SeguridadSocial sss = new EN.SeguridadSocial();
                sss.id = other.id;
                sss.pago_siguiente = other.pago_siguiente;
                sss.pago_anterior = other.pago_anterior;
                sss.conductor = conductoresController.MostarConductor(other.id_conductor).nombre.ToUpper();
                sc.Add(sss);

            }

            return sc;

        }
    }
}
