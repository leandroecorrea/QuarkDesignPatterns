using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class ConexionPostgreSQL : IConexion
    {
        private string host;
        private string puerto;
        private string usuario;
        private string contrasena;

        public ConexionPostgreSQL()
        {
            this.host = "localhost";
            this.puerto = "5433";
            this.usuario = "postgres";
            this.contrasena = "123";
        }

        public void Conectar()
        {
            Console.WriteLine("Se conectó a PostgreSQL");
        }

        public void Desconectar()
        {
            Console.WriteLine("Se desconectó de PostgreSQL");
        }
    }
}
