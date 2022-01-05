using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class ConexionOracle : IConexion
    {
        private string host;
        private string puerto;
        private string usuario;
        private string contrasena;
        public ConexionOracle()
        {
            this.host = "localhost";
            this.puerto = "1521";
            this.usuario = "admin";
            this.contrasena = "123";
        }

        public void Conectar()
        {
            Console.WriteLine("Se conectó a Oracle");
        }

        public void Desconectar()
        {
            Console.WriteLine("Se desconectó de Oracle");
        }
    }
}
