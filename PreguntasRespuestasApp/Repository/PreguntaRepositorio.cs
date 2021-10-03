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
    public class PreguntaRepositorio : BaseRepositorio<Pregunta>
    {
        public Pregunta ObtenerUltima()
        {
            Pregunta pregunta;

            using(DatabaseContext db = new DatabaseContext())
            {
                pregunta = db.Preguntas.OrderByDescending(x => x.Id).FirstOrDefault();
            }

            return pregunta;
        }

        public List<Pregunta> ObtenerTodasConCategoria()
        {
            List<Pregunta> preguntas = new List<Pregunta>();

            using (DatabaseContext db = new DatabaseContext())
            {
                preguntas = db.Preguntas.Include(x => x.Categoria).ToList();
            }

            return preguntas;
        }

        public List<Pregunta> ObtenerPorCategoria(int idCategoria)
        {
            List<Pregunta> preguntas = new List<Pregunta>();

            using (DatabaseContext db = new DatabaseContext())
            {
                preguntas = db.Preguntas.Where(x => x.CategoriaId == idCategoria).Include(x => x.Categoria)
                    .Include(y => y.Respuestas).ToList();
            }

            return preguntas;
        }

        public List<Pregunta> ObtenerPorCategoriaConRespuestas(int idCategoria)
        {
            List<Pregunta> preguntas = new List<Pregunta>();

            using (DatabaseContext db = new DatabaseContext())
            {
                preguntas = db.Preguntas.Where(x => x.CategoriaId == idCategoria).Include(y => y.Respuestas).ToList();
            }

            return preguntas;
        }
    }
}
