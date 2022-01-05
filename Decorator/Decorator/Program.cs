using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta c = new Cuenta(1, "Mitocode");
            ICuentaBancaria cuenta = new CuentaAhorro();
            ICuentaBancaria cuentaBlindada = new BlindajeDecorador(cuenta);
            cuentaBlindada.AbrirCuenta(c);
        }
    }
}
