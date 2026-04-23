using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3.behavioral_patterns.strategy
{
    class StealthAttack : IAttackStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Загін проникає в фортецю непомітно");
        }
    }
}
