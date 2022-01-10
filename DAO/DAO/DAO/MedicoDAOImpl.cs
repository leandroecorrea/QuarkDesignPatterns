using DAO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DAO
{
    class MedicoDAOImpl : MedicoDAO
    {
        List<Medico> lista;

        public MedicoDAOImpl()
        {
            lista = new List<Medico> {
            new Medico{Id = 1, Nombres = "Mario Olivera"},
            new Medico{Id = 2, Nombres = "Rodrigo Pico"},
            new Medico{Id =3, Nombres = "Axel Ochoa"}
            };
        }
        public void Actualizar(Medico medico)
        {
            int index = lista.FindIndex(p => p.Id == medico.Id);
            if (index > -1)
            {
                lista[index] = medico;
                Console.WriteLine($"Medico {medico.Nombres} actualizado");
            }
        }

        public void Eliminar(Medico medico)
        {
            var m = lista.Find(m => m.Id == medico.Id);
            if (m != null)
            {
                lista.Remove(m);
                Console.WriteLine($"Medico {medico.Nombres} eliminado");
            }
        }

        public List<Medico> ListarTodos()
        {
            return lista;
        }

        public Medico ObtenerPorId(int id)
        {
            return lista.Find(m => m.Id == id);
        }

        public void Registrar(Medico medico)
        {
            lista.Add(medico);
            Console.WriteLine($"Medico {medico.Nombres} registrado");
        }
    }
}
