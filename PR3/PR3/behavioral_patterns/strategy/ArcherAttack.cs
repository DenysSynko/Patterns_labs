using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3.behavioral_patterns.strategy
{
    class ArcherAttack : IAttackStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Лучники обстрілюють фортецю");
        }
    }
}
