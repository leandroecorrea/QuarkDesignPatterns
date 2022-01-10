using InyeccionDeDependencia.Conexion;
using InyeccionDeDependencia.DAO;
using System;

namespace InyeccionDeDependencia
{
    class Program
    {
        static void Main(string[] args)
        {
            IConexion cx1 = new ConexionMySQL("mitocode", "7482", "localhost");

            IConexion cx2 = new ConexionPostgreSQL("mitocode", "7482", "192.168.1.1");

            CRUD<Persona> dao = new PersonaDAOImpl(cx1);

            dao.ListarTodos().ForEach(x => Console.WriteLine(x.Nombres));
        }
    }
}
