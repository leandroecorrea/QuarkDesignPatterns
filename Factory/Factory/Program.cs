using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            ConexionFabrica fabrica = new ConexionFabrica();

            IConexion cx1 = fabrica.GetConexion("ORACLE");
            cx1.Conectar();
            cx1.Desconectar();

            IConexion cx2 = fabrica.GetConexion("MYSQL");
            cx2.Conectar();
            cx2.Desconectar();

            IConexion cx3 = fabrica.GetConexion("Quark");
            cx3.Conectar();
            cx3.Desconectar();
        }
    }
}
