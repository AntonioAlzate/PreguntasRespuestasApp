using PreguntasRespuestasApp.Entidades;
using PreguntasRespuestasApp.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreguntasRespuestasApp.Repository
{
    public class CategoriaRepositorio : BaseRepositorio<Categoria>
    {
        public Categoria ObtenerPorNivelDificultad(string nivel)
        {
            Categoria categoria;
            
            using(DatabaseContext db = new DatabaseContext())
            {
                categoria = db.Categorias.Where(x => x.NivelDificultad == nivel).FirstOrDefault();
            }

            return categoria;
        }
    }
}
