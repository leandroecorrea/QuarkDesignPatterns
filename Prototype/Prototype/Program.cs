using System;
using System.Collections.Generic;
using System.Linq;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            CuentaAHImpl cuenta1 = new CuentaAHImpl();            
            CuentaAHImpl copia1 = (CuentaAHImpl)cuenta1.Clone();
            CuentaAHImpl cuenta2 = new CuentaAHImpl();
            cuenta2.Monto = 5000;
            CuentaAHImpl copia2 = (CuentaAHImpl)cuenta2.Clone();
            Console.WriteLine(copia1.ToString());
            Console.WriteLine(copia2.ToString());
            Console.WriteLine(cuenta1 == copia1);
        }       
    }
}
