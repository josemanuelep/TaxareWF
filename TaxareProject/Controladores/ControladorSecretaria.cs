using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxareProject.Controladores
{

    class ControladorSecretaria
    {

        db_taxareEntities1 dbo = new db_taxareEntities1();
        Secretarias_transito secretaria= new Secretarias_transito();

        public List<Secretarias_transito> MostrarSecretarias()
        {

            try
            {
                return dbo.Secretarias_transito.ToList<Secretarias_transito>();
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
        public int MostrarSecretaria(string localidad)
        {

            try
            {
                secretaria = dbo.Secretarias_transito.Where(x => x.localidad == localidad).FirstOrDefault();
                return secretaria.id;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public String MostrarSecretaria_String(int localidad)
        {

            try
            {
                secretaria = dbo.Secretarias_transito.Where(x => x.id == localidad).FirstOrDefault();
                return secretaria.localidad;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }


}
