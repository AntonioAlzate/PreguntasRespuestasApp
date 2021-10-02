using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreguntasRespuestasApp.Entidades
{
    public class Pregunta
    {
        public int Id { get; set; }
        public string Enunciado { get; set; }
        public int CategoriaId { get; set; }
    }
}
