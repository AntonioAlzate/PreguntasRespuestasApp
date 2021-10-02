using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreguntasRespuestasApp.Entidades
{
    public class Categoria
    {
        public int Id { get; set; }
        public int NivelDificultad { get; set; }
        public int Puntos { get; set; }
        public List<Pregunta> Preguntas { get; set; }
    }
}
