using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Cuenta
    {
        public int IdCuenta { get; set; }
        public string Usuario { get; set; }
        public float Saldo { get; set; }

        public Cuenta(int idCuenta, string usuario, float saldo)
        {
            IdCuenta = idCuenta;
            Usuario = usuario;
            Saldo = saldo;
        }
    }
}
