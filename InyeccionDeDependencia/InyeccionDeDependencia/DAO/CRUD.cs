using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDeDependencia.DAO
{
	public interface CRUD<T>
	{
		List<T> ListarTodos();
		T ObtenerPorId(int id);
		void Registrar(T t);
		void Actualizar(T t);
		void Eliminar(T t);
	}
}
