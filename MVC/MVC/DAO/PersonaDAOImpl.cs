using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.DAO
{
    public class PersonaDAOImpl : PersonaDAO
    {
        private IConexion _conexion;
        private string _motor;

        public PersonaDAOImpl(string motor)
        {
            if (motor == "MYSQL")
                _conexion = new MySQL();
            else if (motor == "POSTGRESQL")
                _conexion = new PostgreSQL();
            _conexion.Conectar();
        }

        public List<Persona> Listar()
        {
            List<Persona> personas = new List<Persona>();
            if(_conexion is MySQL)
                personas = RepositorioMySQL();
            if (_conexion is PostgreSQL)
                personas = RepositorioPostgreSQL();
            return personas;
        }

        public List<Persona> RepositorioMySQL()
        {
            return new List<Persona>
            {
                new Persona{ Id = 1, Nombres = "Mito MySQL", Edad = 27 },
                new Persona{ Id = 2, Nombres = "Code", Edad = 27 }
            };
        }
        public List<Persona> RepositorioPostgreSQL()
        {
            return new List<Persona>
            {
                new Persona{ Id = 1, Nombres = "Code PostgreSQL", Edad = 27 },
                new Persona{ Id = 2, Nombres = "Mito", Edad = 27 }
            };
        }
    }
}
