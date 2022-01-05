using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Conexion
    {
        private static Conexion instancia;
        private Conexion()
        { 
        }

        public static Conexion GetInstance()
        {
            if (instancia == null) return new Conexion();
            return instancia;
        }

        public void Conectar()
        {
            Console.WriteLine("Me conecté a la BD");
        }

        public void Desconectar()
        {
            Console.WriteLine("Me desconecté de la BD");
        }
    }
}
