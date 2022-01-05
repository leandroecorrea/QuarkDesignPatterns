using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class BlindajeDecorador : CuentaDecorador
    {
        public BlindajeDecorador(ICuentaBancaria cuentaDecorada) : base(cuentaDecorada)
        {
        }

        public override void AbrirCuenta(Cuenta c)
        {
            base.AbrirCuenta(c);
            AgregarBlindaje(c);
        }

        private void AgregarBlindaje(Cuenta c)
        {
            Console.WriteLine($"Se agregó blindaje a la cuenta del cliente: {c.Cliente}");
        }
    }
}
