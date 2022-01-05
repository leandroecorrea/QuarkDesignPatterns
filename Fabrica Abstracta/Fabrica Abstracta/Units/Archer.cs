using Fabrica_Abstracta.Interfaces;
using System;
namespace Fabrica_Abstracta.Units
{
    class Archer : Unit, IAttack
    {
        private int _range;

        public Archer()
        {
            _attack = 4;
            _name = "Archer";
            _range = 6;

        }
        public void Attack()
        {
            Console.WriteLine($"{_name} has attacked dealing {_attack} damage with {_range} of range.");
        }
    }
}
