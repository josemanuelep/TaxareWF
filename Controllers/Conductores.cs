using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BR = Broker;
using EN = Entities;

namespace Controllers
{
    public class Conductores
    {
        //Entidades para el manejo de la persistencia
        BR.taxareEntities db;

        public Conductores() {

            db = new BR.taxareEntities();
        }


        public bool CrearConductor(EN.Conductor conductor)
        {

            bool resultado = false;
            try
            {
                //Mapeo
                BR.Conductor other = new BR.Conductor();
                other.apellido = conductor.apellido;
                other.cedula = conductor.cedula;
                other.nombre = conductor.nombre;
                other.telefono = conductor.telefono;

                //Persitencia
                db.Conductor.Add(other);
                db.SaveChanges();
                resultado = true;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return resultado;
        }

        public bool EliminaConducor(long id)
        {

            bool resultado = false;
            try
            {
                BR.Conductor conductor = db.Conductor.Where(x => x.id == id).FirstOrDefault();
                db.Conductor.Remove(conductor);
                db.SaveChanges();
                resultado = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return resultado;

        }

        public bool ActualizarConductor(EN.Conductor conductorUpdate)
        {

            bool resultado = false;
            try
            {
                BR.Conductor driver = db.Conductor.Where(x => x.id == conductorUpdate.id).FirstOrDefault();
                driver.apellido = conductorUpdate.apellido;
                driver.cedula = conductorUpdate.cedula;
                driver.nombre = conductorUpdate.nombre;
                driver.telefono = conductorUpdate.telefono;
                db.SaveChanges();
                resultado = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return resultado;

        }
        public List<BR.Conductor> MostrarConductores()
        {

            try
            {
                return db.Conductor.ToList();
                
                
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
        public BR.Conductor MostarConductor(long id)
        {
            try
            {
                return  db.Conductor.Where(x => x.id == id).FirstOrDefault();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public BR.Conductor MostarConductorxNombre(string nombre)
        {
            try
            {
                return db.Conductor.Where(x => x.nombre == nombre).FirstOrDefault();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public BR.Conductor MostarConductorlike(string nombre) {

            try
            {
                return db.Conductor.Where(x => x.nombre.Contains(nombre)).FirstOrDefault();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public BR.Conductor MostarConductorxCedula (string cedula)
        {
            try
            {
                return  db.Conductor.Where(x => x.cedula == cedula).FirstOrDefault();
            
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

     
        public int MostarIdConductor(string cedula)
        {
            try
            {
                return Convert.ToInt32(db.Conductor.Where(x => x.cedula == cedula).FirstOrDefault().id);

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public int Numeroconductores() {

            return db.Conductor.Count();
        }
    }
}
