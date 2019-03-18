﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BR = Broker;
using EN = Entities;

namespace Controllers
{
    public class ConductoresXtaxis
    {
        BR.db_taxareEntities db;
        Conductores conductorController;
        Taxis taxisController;

        public ConductoresXtaxis()
        {
            db = new BR.db_taxareEntities();
            conductorController = new Conductores();
            taxisController = new Taxis();
        }

        public bool CrearCT(EN.ConductoresXtaxis other)
        {
            bool resultado = false;

            try
            {
                string nombre = other.conductor;
                string[] n = nombre.Split(' ');
                BR.ConductoresXtaxis CT = new BR.ConductoresXtaxis(conductorController.MostarConductorxNombre(n[0]).id, other.placaTaxi);
                db.ConductoresXtaxis.Add(CT);
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
                var conductoresTaxis = db.ConductoresXtaxis.Where(x => x.id == id).FirstOrDefault();
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

        public bool ActualizarCT(EN.ConductoresXtaxis other)
        {

            bool resultado = false;

            try
            {
                var update = db.ConductoresXtaxis.Where(x => x.id == other.id).FirstOrDefault();
                string nombre = other.conductor;
                string[] n = nombre.Split(' ');
                update.idConductor = conductorController.MostarConductorxNombre(n[0]).id;
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

        public EN.ConductoresXtaxis MostarCT(long id)
        {

            try
            {
                var  other = db.ConductoresXtaxis.Where(x => x.id == id).FirstOrDefault();
                EN.ConductoresXtaxis CT = new EN.ConductoresXtaxis(other.id, other.Conductor.nombre.ToUpper() + " " + other.Conductor.apellido.ToUpper(), other.placaTaxi);
                return CT;

            }
            catch (Exception)
            {

                throw;
            }
          
        }

        public List<EN.ConductoresXtaxis> ListaCT()
        {
            List<EN.ConductoresXtaxis> ListaCT = new List<EN.ConductoresXtaxis>();

            var query = db.ConductoresXtaxis.ToList();

            foreach (BR.ConductoresXtaxis other in query.ToList())
            {

                EN.ConductoresXtaxis cts = new EN.ConductoresXtaxis(other.id, other.Conductor.nombre.ToUpper() + " " + other.Conductor.apellido.ToUpper(), other.placaTaxi);
                ListaCT.Add(cts);
            }

            return ListaCT;

        }
    }
}
