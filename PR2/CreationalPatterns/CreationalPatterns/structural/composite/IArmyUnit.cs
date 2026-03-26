using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.structural.composite
{
    internal interface IArmyUnit
    {
        void Display(int gap = 0);
        int GetStrength();
    }
}
