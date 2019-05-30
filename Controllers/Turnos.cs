using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BR = Broker;
using EN = Entities;

namespace Controllers
{
    public class Turnos
    {
        //Entidades para el manejo de la persistencia
        BR.taxareEntities db;

        public Turnos()
        {

            db = new BR.taxareEntities();
        }

        public int NumeroTurnos() {

            return db.Turnos.Count();
        }
    }
}
