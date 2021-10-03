using Microsoft.EntityFrameworkCore;
using PreguntasRespuestasApp.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreguntasRespuestasApp.Repository
{
    public abstract class BaseRepositorio<T> : IRepositorio<T> where T : class
    {
        public void Insertar(T entidad)
        {
            using (DatabaseContext db = new DatabaseContext())
            {

                db.Add(entidad);
                db.SaveChanges();
            }
        }

        public T ObtenerPorId(int id)
        {
            using(DatabaseContext db = new DatabaseContext())
            {
                return  db.Set<T>().Find(id);
            }
        }

        public List<T> ObtenerTodos()
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                return db.Set<T>().ToList();
            }
        }
    }
}
