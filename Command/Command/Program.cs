using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta = new Cuenta(1, 200);
            DepositarImpl operacionDeposito = new DepositarImpl(cuenta, 100);
            RetirarImpl operacionRetiro = new RetirarImpl(cuenta, 50);
            Invoker invoker = new Invoker();
            invoker.RecibirOperacion(operacionRetiro);
            invoker.RecibirOperacion(operacionDeposito);
            invoker.RealizarOperaciones();
        }
    }
}
