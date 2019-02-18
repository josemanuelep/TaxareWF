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
        BR.db_taxareEntities db = new BR.db_taxareEntities();

        //Entidad de controladora de conductores para annadir un conductor y hallar la FK
        Conductores conductoresController = new Conductores();

        public bool Crear(EN.SeguridadSocial other, string cedula)
        {

            bool resultado = false;

            try
            {
                //Mapeo de EN BR
                BR.SeguridadSocial ss = new BR.SeguridadSocial();
                ss.id_conductor = conductoresController.MostarIdConductor(cedula);
                ss.pago_anterior = other.pago_anterior;
                ss.pago_siguiente = other.pago_siguiente;
                ss.valor = other.valor;
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

            foreach (BR.SeguridadSocial other in db.SeguridadSocial.ToList())
            {
                EN.SeguridadSocial ss = new EN.SeguridadSocial();
                ss.id = other.id;
                ss.conductor = other.Conductor.nombre.ToUpper()+" " + other.Conductor.apellido.ToUpper();
                ss.pago_anterior = other.pago_anterior;
                ss.pago_siguiente = other.pago_siguiente;
                ss.valor = other.valor;

                list.Add(ss);
            }
            return list ;
        }

        public EN.SeguridadSocial GetSocial(int id)
        {
            EN.SeguridadSocial ss = new EN.SeguridadSocial();
            var other = db.SeguridadSocial.Where(x => x.id == id).FirstOrDefault();

            //Mapeo
            ss.conductor = other.Conductor.nombre.ToUpper() + " " + other.Conductor.apellido.ToUpper();
            ss.id = other.id;
            ss.conductor = other.Conductor.nombre.ToUpper() + " " + other.Conductor.apellido.ToUpper();
            ss.pago_anterior = other.pago_anterior;
            ss.pago_siguiente = other.pago_siguiente;
            ss.valor = other.valor;

            return ss;
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
                sss.conductor = other.Conductor.nombre.ToUpper();
                sc.Add(sss);

            }

            return sc;

        }
    }
}
