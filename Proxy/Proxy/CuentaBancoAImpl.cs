using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class CuentaBancoAImpl : ICuenta
    {
        public Cuenta DepositarDinero(Cuenta cuenta, float monto)
        {    
            if(VerificarAcceso())
            {
                cuenta.Saldo += monto;
                MostrarSaldo(cuenta);
            }
            return cuenta;
        }

        public void MostrarSaldo(Cuenta cuenta)
        {
            Console.WriteLine($"Saldo actual: {cuenta.Saldo}");
        }

        public Cuenta RetirarDinero(Cuenta cuenta, float monto)
        {
            if (VerificarAcceso())
            {
                MostrarSaldo(cuenta);
                cuenta.Saldo -= monto;
            }
            return cuenta;
        }
        public bool VerificarAcceso()
        {            
            Console.WriteLine("Proxy: Pedido a proxy, realizando verificaciones previas a efectuar el pedido al objeto de clase CuentaBancoAImpl.");
            return true;
        }
    }
}
