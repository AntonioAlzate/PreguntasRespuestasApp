using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreguntasRespuestasApp.Entidades
{
    public class Puntaje
    {
        public int Id { get; set; }
        public int Valor { get; set; }
        public int RondaId { get; set; }
        public Ronda Ronda { get; set; }
        public int JugadorId { get; set; }
        public Jugador Jugador { get; set; }
    }
}
