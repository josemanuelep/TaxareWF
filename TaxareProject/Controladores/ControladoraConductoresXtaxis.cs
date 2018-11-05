using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxareProject.Controladores
{
    class ControladoraConductoresXtaxis
    {

        db_taxareEntities1 db = new db_taxareEntities1();
        ConductoresXtaxi conductoresTaxis = new ConductoresXtaxi();
        Conductor conductor = new Conductor();
        Taxi tx = new Taxi();

        //Clase para los joins
        Querys.ConductoresxTaxis Join = new Querys.ConductoresxTaxis();

        //Controladores
        ControladorConductores conController = new ControladorConductores();
        ControladorTaxis txController = new ControladorTaxis();

        public bool CrearCT(ConductoresXtaxi other)
        {
            bool resultado = false;

            try
            {
                db.ConductoresXtaxis.Add(other);
                db.SaveChanges();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;

        }

        public bool EliminarCT(long id)
        {

            bool resultado = false;

            try
            {
                conductoresTaxis = db.ConductoresXtaxis.Where(x => x.id == id).FirstOrDefault();
                db.ConductoresXtaxis.Remove(conductoresTaxis);
                db.SaveChanges();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }

        public bool ActualizarCT(ConductoresXtaxi other)
        {

            bool resultado = false;

            try
            {
                var update = db.ConductoresXtaxis.Where(x => x.id == other.id).FirstOrDefault();
                update.idConductor = other.idConductor;
                update.placaTaxi = other.placaTaxi;
                db.SaveChanges();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }

        public ConductoresXtaxi MostarCT(long id)
        {

            try
            {
                conductoresTaxis = db.ConductoresXtaxis.Where(x => x.id == id).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
            return conductoresTaxis;
        }

        public List<Querys.ConductoresxTaxis> ListaCT()
        {
            List<Querys.ConductoresxTaxis> ListaCT = new List<Querys.ConductoresxTaxis>();

            var query =
                    from cxt in db.ConductoresXtaxis
                    join conductor in db.Conductors on cxt.idConductor equals conductor.id
                    join tx in db.Taxis on cxt.placaTaxi equals tx.placa
                    //into consulta
                    select new
                    {   
                        
                        id = cxt.id,
                        nombre = conductor.nombre,
                        apellido = conductor.apellido,
                        placa = tx.placa.ToUpper()

                    };

            foreach (var other in query.ToList()) {

                Querys.ConductoresxTaxis cts = new Querys.ConductoresxTaxis();
                cts.Id = other.id;
                cts.nombre = other.nombre;
                cts.apellido = other.apellido;
                cts.placa = other.placa;
                ListaCT.Add(cts);
            }

            return ListaCT;

        }
    }
}






