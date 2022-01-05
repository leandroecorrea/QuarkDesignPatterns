using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Conexion c = Conexion.GetInstance();
            c.Conectar();
            c.Desconectar();

            bool respuesta = typeof(Conexion).IsInstanceOfType(c);
            Console.WriteLine(respuesta);
        }
    }
}
