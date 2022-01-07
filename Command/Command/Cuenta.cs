using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Cuenta
    {
        private int _idCuenta;
        private float _saldo;

        public Cuenta(int idCuenta, float saldo)
        {
            _idCuenta = idCuenta;
            _saldo = saldo;
        }
        
        public void Retirar(float monto)
        {
            _saldo -= monto;
            Console.WriteLine($"[COMANDO RETIRAR] Cuenta: {_idCuenta} Saldo: {_saldo}");
        }
        public void Depositar(float monto)
        {
            _saldo += monto;
            Console.WriteLine($"[COMANDO DEPOSITAR] Cuenta: {_idCuenta} Saldo: {_saldo}");
        }
    }
}
