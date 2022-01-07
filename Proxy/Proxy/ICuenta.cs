using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public interface ICuenta
    {
        Cuenta RetirarDinero(Cuenta cuenta, float monto);
        Cuenta DepositarDinero(Cuenta cuenta, float monto);
        void MostrarSaldo(Cuenta cuenta);
    }
}
