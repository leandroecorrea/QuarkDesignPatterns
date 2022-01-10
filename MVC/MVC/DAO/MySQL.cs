using System;

namespace MVC.DAO
{
    internal class MySQL : IConexion
    {
        public void Conectar()
        {
            Console.WriteLine("Conexión a SQL");
        }
    }
}