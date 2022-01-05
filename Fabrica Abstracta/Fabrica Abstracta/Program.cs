using Fabrica_Abstracta.Interfaces;
using Fabrica_Abstracta.UnitFactories;
using System;

namespace Fabrica_Abstracta
{
    class Program
    {
        static void Main(string[] args)
        {

            IUnitFactory f1 = new RangedUnitFactory();
            Building b1 = new Building(f1);

            IUnitFactory f2 = new InfantryFactory();
            Building b2 = new Building(f2);

            Unit u1 = b1.GetUnit();
            if (u1 is IAttack)
                (u1 as IAttack).Attack();
            Unit u2 = b2.GetUnit();
            if (u2 is IAttack)
                (u2 as IAttack).Attack();
        }
    }
}
