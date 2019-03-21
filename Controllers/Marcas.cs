using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BR = Broker;
using EN = Entities;

namespace Controllers
{
    public class Marcas
    {
        BR.db_taxareEntities db = new BR.db_taxareEntities();
        Marcas marcaController = new Marcas();


        public List<BR.Marcas> MostrarMarcas()
        {

            try
            {
                return db.Marcas.ToList<BR.Marcas>();
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
        public int MostrarMarca(string marca)
        {
            try
            {
                
                return db.Marcas.Where(x => x.marca == marca).FirstOrDefault().id;

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public string MostrarMarca_String(int marca)
        {
            try
            {

                return db.Marcas.Where(x => x.id == marca).FirstOrDefault().marca; 

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}
