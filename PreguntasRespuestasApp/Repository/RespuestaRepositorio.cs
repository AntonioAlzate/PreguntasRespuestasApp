using PreguntasRespuestasApp.Entidades;
using PreguntasRespuestasApp.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreguntasRespuestasApp.Repository
{
    public class RespuestaRepositorio : BaseRepositorio<Respuesta>
    {
        public void Insertar(List<Respuesta> respuestas)
        {
            using(DatabaseContext db = new DatabaseContext())
            {
                db.Respuestas.AddRange(respuestas);
                db.SaveChanges();
            }
        }
    }
}
