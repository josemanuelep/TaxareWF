using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class Taxi
    {

        private BB db = new BR.db_taxareEntities2();

     

        public bool CrearTaxi(EN.Taxi taxi)
        {

            bool resultado = false;
            try
            {
                Mapper.Initialize(cfg => {
                    cfg.CreateMap<EN.Taxi, BR.Taxis>();
                });
                BR.Taxis tx = Mapper.Map<BR.Taxis>(taxi);
                db.Taxis.Add(tx);
                db.SaveChanges();
                resultado = true;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return resultado;
        }

        public bool EliminarTaxi(string txplaca)
        {

            bool resultado = false;
            try
            {
                BR.Taxis tx = db.Taxis.Where(x => x.placa == txplaca).FirstOrDefault();
                db.Taxis.Remove(tx);
                db.SaveChanges();
                resultado = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return resultado;

        }

        public bool ActualizarTaxi(EN.Taxi taxi_update)
        {

            bool resultado = false;
            try
            {
                BR.Taxis tx = db.Taxis.Where(x => x.placa == taxi_update.placa).FirstOrDefault();
                Mapper.Initialize(cfg => {
                    cfg.CreateMap<EN.Taxi, BR.Taxis>();
                });

                tx = Mapper.Map<BR.Taxis>(taxi_update);
                db.SaveChanges();
                resultado = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return resultado;

        }

    }
}
