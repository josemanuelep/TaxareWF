using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BR = Broker;
using EN = Entities;

namespace Controllers
{
    public class Produccion
    {
       BR. db_taxareEntities db = new BR.db_taxareEntities();

        public bool CrearProduccion(EN.Produccion other)
        {


            bool resultado = false;
            try
            {
                //Mapeo
                BR.Produccion produccion = new BR.Produccion();
                produccion.idTurno = other.idTurno;
                produccion.producido = other.producido;
                //Insert en la BD
                db.Produccion.Add(produccion);
                db.SaveChanges();
                resultado = true;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return resultado;


        }

        public bool EliminarPrduccion(long id)
        {

            bool resultado = false;
            try
            {

                var pro = db.Produccion.Where(x => x.id == id).FirstOrDefault();
                db.Produccion.Remove(pro);
                db.SaveChanges();
                resultado = true;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return resultado;


        }

        public bool ActualizarProduccion(EN.Produccion other)
        {

            bool resultado = false;
            try
            {

                var pro = db.Produccion.Where(x => x.id == other.id).FirstOrDefault();
                pro.idTurno = other.idTurno;
                pro.producido = other.producido;     
                db.SaveChanges();
                resultado = true;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return resultado;
        }

        public List<EN.Produccion> Producciones()
        {
            List<EN.Produccion> ListaPT = new List<EN.Produccion>();

            var query = db.Produccion.ToList();


            foreach (BR.Produccion other in query)
            {

                EN.Produccion p = new EN.Produccion();
                //Mapeo y calculos
                TimeSpan dias = other.Turnos.fin - other.Turnos.inicio;
                p.conductor = other.Turnos.Conductor.nombre.ToUpper() + " " + other.Turnos.Conductor.apellido.ToUpper();
                p.dias = dias.Days;
                p.idTurno = other.idTurno;
                p.placa = other.Turnos.placaTaxi;
                p.producido = other.producido;
                ListaPT.Add(p);

            }

            return ListaPT;

        }

        public EN.Produccion produccion(long id)
        {
            var other = db.Produccion.Where(x => x.id == id).FirstOrDefault();
            EN.Produccion p = new EN.Produccion();

            TimeSpan dias = other.Turnos.fin - other.Turnos.inicio;
            p.conductor = other.Turnos.Conductor.nombre.ToUpper() + " " + other.Turnos.Conductor.apellido.ToUpper();
            p.dias = dias.Days;
            p.idTurno = other.idTurno;
            p.placa = other.Turnos.placaTaxi;
            p.producido = other.producido;

            return p;

        }

        //public List<EN.Produccion> BuscarProduccionPorPlaca(string placa)
        //{
        //    List<EN.Produccion> ListaPT = new List< EN.Produccion > ();

        //    var query =

        //            from p in db.Produccions
        //            join c in db.Conductors on p.id_taxista equals c.id
        //            where p.placa.Equals(placa)
        //            select new
        //            {

        //                id = p.id,
        //                placa = p.placa.ToUpper(),
        //                conductor = c.nombre.ToUpper() + " " + c.apellido.ToUpper(),
        //                inicio = p.inicio,
        //                final = p.final,
        //                valor = p.valor

        //            };

        //    foreach (var other in query.ToList())
        //    {

        //        Querys.ProduccionxTaxis pxt = new Querys.ProduccionxTaxis();

        //        pxt.id = other.id;
        //        TimeSpan resto = other.final - other.inicio;
        //        double total = resto.TotalDays + 1;
        //        pxt.dias = total;
        //        pxt.placa = other.placa;
        //        pxt.conductor = other.conductor;
        //        pxt.inicio = other.inicio;
        //        pxt.final = other.final;
        //        pxt.valor = other.valor;
        //        ListaPT.Add(pxt);

        //    }

        //    return ListaPT;

        //}

        //public List<Querys.ProduccionxTaxis> BuscarProduccionPorConductor(long idConductor)
        //{

        //    List<Querys.ProduccionxTaxis> ListaPT = new List<Querys.ProduccionxTaxis>();

        //    var query =

        //            from p in db.Produccions
        //            join c in db.Conductors on p.id_taxista equals c.id
        //            where p.id_taxista == idConductor
        //            select new
        //            {

        //                id = p.id,
        //                placa = p.placa.ToUpper(),
        //                conductor = c.nombre.ToUpper() + " " + c.apellido.ToUpper(),
        //                inicio = p.inicio,
        //                final = p.final,
        //                valor = p.valor

        //            };

        //    foreach (var other in query.ToList())
        //    {

        //        Querys.ProduccionxTaxis pxt = new Querys.ProduccionxTaxis();

        //        pxt.id = other.id;
        //        TimeSpan resto = other.final - other.inicio;
        //        double total = resto.TotalDays + 1;
        //        pxt.dias = total;
        //        pxt.placa = other.placa;
        //        pxt.conductor = other.conductor;
        //        pxt.inicio = other.inicio;
        //        pxt.final = other.final;
        //        pxt.valor = other.valor;
        //        ListaPT.Add(pxt);

        //    }

        //    return ListaPT;

        //}

        public long id(int idc)
        {

            return db.Produccion.Where(x => x.Turnos.idConductor == idc).FirstOrDefault().id;

        }

    }
}
