using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class ConexionSQLServer : IConexion
    {
        private string host;
        private string puerto;
        private string usuario;
        private string contrasena;

        public ConexionSQLServer()
        {
            this.host = "localhost";
            this.puerto = "1433";
            this.usuario = "SQLServerUser";
            this.contrasena = "123";
        }

        public void Conectar()
        {
            Console.WriteLine("Se conectó a SQLServer");
        }

        public void Desconectar()
        {
            Console.WriteLine("Se desconectó de SQLServer");
        }
    }
}
