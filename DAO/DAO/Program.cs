using System;
using DAO.DAO;

namespace DAO
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonaDAO personaDAO = new PersonaDAOImpl();
            personaDAO.ListarTodos().ForEach(p => Console.WriteLine("Persona: " +  p.Nombres));
            personaDAO.Actualizar(new Model.Persona { Id = 1, Nombres = "Daniel Rodriguez" });
            personaDAO.Eliminar(new Model.Persona { Id = 2 });
            personaDAO.ListarTodos().ForEach(p => Console.WriteLine("Persona: "+ p.Nombres));
            Console.WriteLine("Obtener por ID = 1: " + personaDAO.ObtenerPorId(1).Nombres);

            MedicoDAO medicoDAO = new MedicoDAOImpl();
            medicoDAO.ListarTodos().ForEach(m => Console.WriteLine("Medico: " + m.Nombres));
        }
    }
}
