using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3.behavioral_patterns.strategy
{
    class MeleeAttack : IAttackStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Піхота йде в лобову атаку");
        }
    }
}
