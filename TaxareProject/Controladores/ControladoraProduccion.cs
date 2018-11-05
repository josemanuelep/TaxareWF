using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxareProject.Controladores
{
    class ControladoraProduccion
    {
        db_taxareEntities1 db = new db_taxareEntities1();

        public bool CrearProduccion(Produccion other) {


            bool resultado = false;
            try
            {

                db.Produccions.Add(other);
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

                var pro = db.Produccions.Where(x=> x.id==id).FirstOrDefault();
                db.Produccions.Remove(pro);
                db.SaveChanges();
                resultado = true;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return resultado;


        }

        public bool ActualizarProduccion(Produccion other) {

            bool resultado = false;
            try
            {

                var pro = db.Produccions.Where(x => x.id == other.id).FirstOrDefault();
                pro.final = other.final;
                pro.id_taxista = other.id_taxista;
                pro.inicio = other.inicio;
                pro.placa = other.placa;
                pro.valor = other.valor;
                db.SaveChanges();
                resultado = true;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return resultado;
        }

        public List<Querys.ProduccionxTaxis> ListaPT()
        {
            List<Querys.ProduccionxTaxis> ListaPT = new List<Querys.ProduccionxTaxis>();

            var query =

                    from p in db.Produccions
                    join c in db.Conductors on p.id_taxista equals c.id
                    select new
                    {

                        id = p.id,
                        placa = p.placa.ToUpper(),
                        conductor = c.nombre.ToUpper() + " " + c.apellido.ToUpper(),
                        inicio = p.inicio,
                        final = p.final,
                        valor= p.valor

                    };

            foreach (var other in query.ToList())
            {

                Querys.ProduccionxTaxis pxt = new Querys.ProduccionxTaxis();
                pxt.id = other.id;
                pxt.placa = other.placa;
                pxt.conductor = other.conductor;
                pxt.inicio = other.inicio;
                pxt.final = other.final;
                pxt.valor = other.valor;
                ListaPT.Add(pxt);
                
            }

            return ListaPT;

        }

    }
}
