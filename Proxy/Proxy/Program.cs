using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta c = new Cuenta(1, "mitocode", 100);

            ICuenta cuentaProxy = new CuentaProxy(new CuentaBancoAImpl());
            cuentaProxy.MostrarSaldo(c);
            c = cuentaProxy.DepositarDinero(c, 50);
            c = cuentaProxy.RetirarDinero(c, 20);
            cuentaProxy.MostrarSaldo(c);
        }
    }
} 
