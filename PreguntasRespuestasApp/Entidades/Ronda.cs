using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreguntasRespuestasApp.Entidades
{
    public class Ronda
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public List<Puntaje> Puntajes { get; set; }
    }
}
