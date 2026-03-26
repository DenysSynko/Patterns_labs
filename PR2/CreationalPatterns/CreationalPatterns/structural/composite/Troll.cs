using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.structural.composite
{
    internal class TrollUnit : IArmyUnit
    {
        public void Display(int gap = 0)
        {
            Console.WriteLine(new string(' ', gap) + "- Troll");
        }

        public int GetStrength() => 6;
    }
}
