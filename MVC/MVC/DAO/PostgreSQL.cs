using System;

namespace MVC.DAO
{
    internal class PostgreSQL : IConexion
    {
        public void Conectar()
        {
            Console.WriteLine("Conexión a SQL");
        }
    }
}