using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class CuentaAHImpl : ICloneable
    {
        private string tipo;
        public float Monto { get; set; }

        public CuentaAHImpl()
        {
            this.tipo = "AHORRO";
        }

        // Agrego, comentada, la implementación sugerida en Refactoring Guru para Java
        //public CuentaAHImpl(CuentaAHImpl target)
        //{
        //    if (target != null)
        //    {
        //        this.Monto = target.Monto;
        //        this.tipo = target.tipo;
        //    }
        //}

        public object Clone()
        {
            //CuentaAHImpl clone = new CuentaAHImpl(this);
            //return clone;
            return this.MemberwiseClone();

        }
        public override string ToString()
        {
            return $"CuentaAHImpl [tipo={tipo}, monto= {Monto}].";
        }
    }
}
