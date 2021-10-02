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
        public Categoria Categoria { get; set; }
        public List<Respuesta> Respuestas { get; set; }
    }
}
