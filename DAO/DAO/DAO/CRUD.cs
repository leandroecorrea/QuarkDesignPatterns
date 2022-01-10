using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DAO
{
    public interface CRUD<T>
    {
        List<T> ListarTodos();
        T ObtenerPorId(int id);
        void Registrar(T o);
        void Actualizar(T o);
        void Eliminar(T o);
    }
}
