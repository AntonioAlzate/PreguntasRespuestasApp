using PreguntasRespuestasApp.Entidades;
using PreguntasRespuestasApp.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreguntasRespuestasApp.Repository
{
    public class JugadorRepositorio : BaseRepositorio<Jugador>
    {
        public Jugador ObtenerPorNombre(string nombre)
        {
            Jugador jugador;
            using(DatabaseContext db = new DatabaseContext())
            {
                jugador = db.Jugadores.Where(x => x.NombreUsuario == nombre).FirstOrDefault();
            }
            return jugador;
        }

        public bool ExistenciaPorNombre(string nombre)
        {
            bool existe;
            using (DatabaseContext db = new DatabaseContext())
            {
                existe = db.Jugadores.Any(x => x.NombreUsuario == nombre);
            }
            return existe;
        }
    }
}
