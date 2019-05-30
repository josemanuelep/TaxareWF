using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BR = Broker;
using EN = Entities;

namespace Controllers
{
    public class Transito
    {

        BR.taxareEntities dbo = new BR.taxareEntities();

        public List<BR.Secretarias_transito> MostrarSecretarias()
        {

            try
            {
                return dbo.Secretarias_transito.ToList<BR.Secretarias_transito>();
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
                return dbo.Secretarias_transito.Where(x => x.localidad == localidad).FirstOrDefault().id;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public String MostrarSecretaria_String(int id)
        {

            try
            {
                return dbo.Secretarias_transito.Where(x => x.id == id).FirstOrDefault().localidad;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
