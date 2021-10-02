using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreguntasRespuestasApp.Entidades
{
    public class Respuesta
    {
        public int Id { get; set; }
        public int PreguntaId { get; set; }
        public Pregunta Pregunta { get; set; }
        public string Contenido { get; set; }
        public bool EsCorrecta { get; set; }
    }
}
