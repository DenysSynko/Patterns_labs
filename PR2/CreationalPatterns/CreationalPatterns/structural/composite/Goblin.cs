using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.structural.composite
{
    internal class GoblinUnit : IArmyUnit
    {
        public void Display(int gap = 0)
        {
            Console.WriteLine(new string(' ', gap) + "- Goblin");
        }

        public int GetStrength() => 1;
    }
}
