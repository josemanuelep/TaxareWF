using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxareProject.Controladores
{
    class ControladorMarcas
    {
        db_taxareEntities1 db = new db_taxareEntities1();
        Marca mr = new Marca();

        public List<Marca> MostrarMarcas()
        {

            try
            {
                return db.Marcas.ToList<Marca>();
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
                mr = db.Marcas.Where(x => x.marca1 == marca).FirstOrDefault();
                return mr.id;
                
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public String MostrarMarca_String(int marca)
        {
            try
            {
                mr = db.Marcas.Where(x => x.id == marca).FirstOrDefault();
                return mr.marca1;

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }


    }

}
