using InyeccionDeDependencia.Conexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDeDependencia.DAO
{
    public class PersonaDAOImpl : PersonaDAO
    {
        IConexion _conexion;
        List<Persona> lista;
        
        public PersonaDAOImpl(IConexion conexion)
        {
            _conexion = conexion;
            lista = new List<Persona> {
            new Persona{Id = 1, Nombres = "Juan Perez"},
            new Persona{Id = 2, Nombres = "María Antonieta"},
            new Persona{Id =3, Nombres = "Azul Rodrigo"}
            };
        }


        public void Actualizar(Persona persona)
        {
            int index = lista.FindIndex(p => p.Id == persona.Id);
            if (index > -1)
            {
                lista[index] = persona;
                Console.WriteLine($"Persona {persona.Nombres} actualizada");
            }
        }

        public void Eliminar(Persona persona)
        {
            var p = lista.Find(p => p.Id == persona.Id);
            if (p != null)
            {
                lista.Remove(p);
                Console.WriteLine($"Persona {persona.Nombres} eliminada");
            }
        }

        public List<Persona> ListarTodos()
        {
            _conexion.Conectar();
            return lista;
        }

        public Persona ObtenerPorId(int id)
        {
            return lista.Find(p => p.Id == id);
        }

        public void Registrar(Persona persona)
        {
            lista.Add(persona);
            Console.WriteLine($"Persona {persona.Nombres} registradda");
        }
    }
}
