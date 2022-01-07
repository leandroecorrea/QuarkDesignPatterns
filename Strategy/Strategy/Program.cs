using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Antivirus a = new Antivirus(new AnalisisSimple());
            a.Ejecutar();
            Antivirus b = new Antivirus(new AnalisisAvanzado());
            b.Ejecutar();
        }
    }
}
