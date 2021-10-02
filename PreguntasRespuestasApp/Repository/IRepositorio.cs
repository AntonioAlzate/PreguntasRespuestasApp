using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreguntasRespuestasApp.Repository
{
    public interface IRepositorio<T>
    {
        void Insertar(T entidad);
        T ObtenerPorId(int id);
        List<T> ObtenerTodos();
    }
}
