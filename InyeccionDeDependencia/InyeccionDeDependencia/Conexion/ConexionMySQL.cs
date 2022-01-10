using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDeDependencia.Conexion
{
    public class ConexionMySQL : IConexion
    {
        private string usuario;
        private string clave;
        private string host;

        public ConexionMySQL(string usuario, string clave, string host)
        {
            this.usuario = usuario;
            this.clave = clave;
            this.host = host;
        }

        public void Conectar()
        {
            Console.WriteLine("Conectando a MySQL");
        }
    }
}
