using Fabrica_Abstracta.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica_Abstracta.Units
{
    class Militia : Unit, IAttack
    {
        public Militia()
        {
            _attack = 5;
            _name = "Militia";
        }

        public void Attack()
        {
            Console.WriteLine($"{_name} has attacked dealing {_attack} damage.");
        }
    }
}
