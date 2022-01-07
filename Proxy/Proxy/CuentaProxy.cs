using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class CuentaProxy : ICuenta
    {
        private ICuenta _cuentaReal;

        public CuentaProxy(ICuenta cuentaReal)
        {
            _cuentaReal = cuentaReal;
        }

        public Cuenta DepositarDinero(Cuenta cuenta, float monto)
        {            
            return _cuentaReal.DepositarDinero(cuenta, monto);            
        }

        public void MostrarSaldo(Cuenta cuenta)
        {         
            _cuentaReal.MostrarSaldo(cuenta);            
        }

        public Cuenta RetirarDinero(Cuenta cuenta, float monto)
        {
            return _cuentaReal.RetirarDinero(cuenta, monto);
        }
    }
}
