using Fabrica_Abstracta.Interfaces;
using Fabrica_Abstracta.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica_Abstracta.UnitFactories
{
    class InfantryFactory : IUnitFactory
    {
        private static readonly string name = "BARRACKS";
        private float _productionSpeed;
        public InfantryFactory()
        {
            _productionSpeed = 0.8f;
        }

        public Unit CreateUnit()
        {
            return new Militia();
        }
    }
}
