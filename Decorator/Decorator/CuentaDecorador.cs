using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class CuentaDecorador : ICuentaBancaria
    {
        protected ICuentaBancaria _cuentaDecorada;

        public CuentaDecorador(ICuentaBancaria cuentaDecorada)
        {
            _cuentaDecorada = cuentaDecorada;
        }

        public virtual void AbrirCuenta(Cuenta c)
        {
            _cuentaDecorada.AbrirCuenta(c);
        }
    }
}
