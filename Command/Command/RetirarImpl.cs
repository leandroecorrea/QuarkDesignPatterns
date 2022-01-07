using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class RetirarImpl : IOperacion
    {
        private Cuenta _cuenta;
        private float _monto;

        public RetirarImpl(Cuenta cuenta, float monto)
        {
            _cuenta = cuenta;
            _monto = monto;
        }

        public void Ejecutar()
        {
            _cuenta.Retirar(_monto);
        }
    }
}
