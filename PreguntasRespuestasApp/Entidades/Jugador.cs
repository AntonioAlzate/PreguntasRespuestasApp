using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreguntasRespuestasApp.Entidades
{
    public class Jugador
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public List<Puntaje> Puntajes { get; set; }
    }
}
