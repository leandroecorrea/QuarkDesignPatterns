using Fabrica_Abstracta.Interfaces;
using Fabrica_Abstracta.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica_Abstracta.UnitFactories
{
    class RangedUnitFactory : IUnitFactory
    {
        private static readonly string name = "ARCHER_RANGE";
        private float _productionSpeed;
        public RangedUnitFactory()
        {
            _productionSpeed = 0.5f;
        }

        public Unit CreateUnit()
        {
            return new Archer();
        }
    }
}
