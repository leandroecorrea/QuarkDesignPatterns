using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class ConexionVacia : IConexion
    {
        public void Conectar()
        {
            Console.WriteLine("No se especificó proveedor");
        }

        public void Desconectar()
        {
            Console.WriteLine("No se especificó proveedor");
        }
    }
}
