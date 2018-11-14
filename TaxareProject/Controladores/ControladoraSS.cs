using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxareProject.Controladores
{
    class ControladoraSS
    {
        db_taxareEntities1 db = new db_taxareEntities1();


        public bool Crear(SeguridadSocial other)
        {

            bool resultado = false;

            try
            {
                db.SeguridadSocials.Add(other);
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
                var d = db.SeguridadSocials.Where(x => x.id == id).FirstOrDefault();
                db.SeguridadSocials.Remove(d);
                db.SaveChanges();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }

        public bool Actualizar(SeguridadSocial other)
        {

            bool resultado = false;

            try
            {
                var d = db.SeguridadSocials.Where(x => x.id == other.id).FirstOrDefault();
                d.id_conductor = other.id_conductor;
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

        public List<SeguridadSocial> GetSocials()
        {

            return db.SeguridadSocials.ToList();
        }

        public SeguridadSocial GetSocial(int id)
        {

            return db.SeguridadSocials.Where(x => x.id == id).FirstOrDefault();
        }

        public Double SumaTotal()
        {
            System.Nullable<Double> totalFreight = (from p in db.SeguridadSocials select p.valor).Sum();

            return Convert.ToDouble(totalFreight);

        }

        public List<SeguridadSocial> VencenDosDias()
        {

            Controladores.ControladorConductores cc = new ControladorConductores();
            List<SeguridadSocial> sc = new List<SeguridadSocial>();

            DateTime dias = new DateTime();
            dias = DateTime.Today.AddDays(2);

            var q = db.SeguridadSocials.Where(x => x.pago_siguiente == dias).ToList();

            foreach (var other in q)
            {
                SeguridadSocial sss = new SeguridadSocial();
                sss.id = other.id;
                sss.pago_siguiente = other.pago_siguiente;
                sss.id_conductor = other.id_conductor;
                sc.Add(sss);

            }

            return sc;

        }

        public List<SeguridadSocial> Vencidos()
        {

            Controladores.ControladorConductores cc = new ControladorConductores();
            List<SeguridadSocial> sc = new List<SeguridadSocial>();

            DateTime dias = new DateTime();
            dias = DateTime.Today;

            var q = db.SeguridadSocials.Where(x => x.pago_siguiente <= dias).ToList();

            foreach (var other in q)
            {
                SeguridadSocial sss = new SeguridadSocial();
                sss.id = other.id;
                sss.pago_siguiente = other.pago_siguiente;
                sss.id_conductor = other.id_conductor;
                sc.Add(sss);

            }

            return sc;

        }



    }
}
