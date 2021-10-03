using PreguntasRespuestasApp.Entidades;
using PreguntasRespuestasApp.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreguntasRespuestasApp.Repository
{
    public class RondaRepositorio : BaseRepositorio<Ronda>
    {
        public int ObtenerPorValor(int ronda)
        {
            int idRonda = 0;

            using(DatabaseContext db = new DatabaseContext())
            {
                idRonda = db.Rondas.FirstOrDefault(x => x.Numero == ronda).Id;
            }

            return idRonda;
        }
    }
}
