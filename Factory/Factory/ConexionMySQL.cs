using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class ConexionMySQL : IConexion
    {
        private string host;
        private string puerto;
        private string usuario;
        private string contrasena;

        public ConexionMySQL()
        {
            this.host = "localhost";
            this.puerto = "3306";
            this.usuario = "root";
            this.contrasena = "123";
        }

        public void Conectar()
        {
            Console.WriteLine("Se conectó a MySQL");
        }

        public void Desconectar()
        {
            Console.WriteLine("Se desconectó de MySQL");
        }
    }
}
