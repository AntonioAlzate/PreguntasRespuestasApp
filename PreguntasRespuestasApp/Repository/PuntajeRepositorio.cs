using Microsoft.EntityFrameworkCore;
using PreguntasRespuestasApp.Entidades;
using PreguntasRespuestasApp.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreguntasRespuestasApp.Repository
{
    public class PuntajeRepositorio : BaseRepositorio<Puntaje>
    {
        public List<Puntaje> ObtenerTodosConJugadorRonda()
        {
            List<Puntaje> puntajes = new List<Puntaje>();

            using (DatabaseContext db = new DatabaseContext())
            {
                puntajes = db.Puntajes.Include(x => x.Jugador).Include(x => x.Ronda)
                    .OrderByDescending(x=> x.Valor).ToList();
            }

            return puntajes;
        }

        internal List<Puntaje> ObtenerTodosPorNombre(int jugadorId)
        {
            List<Puntaje> puntajes = new List<Puntaje>();

            using (DatabaseContext db = new DatabaseContext())
            {
                puntajes = db.Puntajes.Where(x => x.JugadorId == jugadorId)
                    .Include(x => x.Jugador).Include(x => x.Ronda)
                    .OrderByDescending(x => x.Valor).ToList();
            }

            return puntajes;
        }
    }
}
