using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BR = Broker;
using EN = Entities;

namespace Controllers
{
    class ConductoresXtaxis
    {
        BR.db_taxareEntities db = new BR.db_taxareEntities();
        BR.ConductoresXtaxis conductoresTaxis = new BR.ConductoresXtaxis();
        BR.Conductor conductor = new BR.Conductor();
        BR.Taxis tx = new BR.Taxis();

        

        //Controladores
        Conductores conController = new Conductores();
        Taxis txController = new Taxis();

        public bool CrearCT(int idConductor, string idplaca)
        {
            bool resultado = false;

            try
            {
                BR.ConductoresXtaxis conductoresXtaxis = new BR.ConductoresXtaxis();
                conductoresXtaxis.idConductor = idConductor;
                conductoresXtaxis.placaTaxi = idplaca;
                db.ConductoresXtaxis.Add(conductoresXtaxis);
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

        public bool ActualizarCT(int idConductor, string placa, int id)
        {

            bool resultado = false;

            try
            {
                var update = db.ConductoresXtaxis.Where(x => x.id == id).FirstOrDefault();
                update.idConductor = idConductor;
                update.placaTaxi = placa;
                db.SaveChanges();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }

        public EN.ConductoresXtaxis MostarCT(long id)
        {
            EN.ConductoresXtaxis conductoresXtaxis = new EN.ConductoresXtaxis();

            try
            {
               BR.ConductoresXtaxis other = db.ConductoresXtaxis.Where(x => x.id == id).FirstOrDefault();

                //Mapeo
                conductoresXtaxis.conductor = other.Conductor.nombre.ToUpper() + " " + other.Conductor.apellido.ToUpper();
                conductoresXtaxis.placaTaxi = other.placaTaxi;
                conductoresTaxis.id = other.id;
            }
            catch (Exception)
            {

                throw;
            }
            return conductoresXtaxis;
        }

        public List<EN.ConductoresXtaxis> ListaCT()
        {
            List<EN.ConductoresXtaxis> ListaCT = new List<EN.ConductoresXtaxis>();

            foreach (var item in db.ConductoresXtaxis.ToList<BR.ConductoresXtaxis>())
            {
                EN.ConductoresXtaxis CT = new EN.ConductoresXtaxis();
                CT.conductor =  item.Conductor.nombre.ToUpper() + " " + item.Conductor.apellido.ToUpper();
                CT.placaTaxi = item.placaTaxi;
                CT.id = item.id;

            }
           
            return ListaCT;

        }
    }
}
