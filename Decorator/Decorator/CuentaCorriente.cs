using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class CuentaCorriente : ICuentaBancaria
    {
        public void AbrirCuenta(Cuenta c)
        {
            Console.WriteLine("Se abrió una cuenta de ahorros");
            Console.WriteLine($"Cliente: {c.Cliente}");
        }
    }
}
