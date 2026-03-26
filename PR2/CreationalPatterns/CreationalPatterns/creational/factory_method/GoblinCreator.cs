using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.creational.factory_method
{
    internal class GoblinCreator : Creator
    {
        public override Orc CreateOrc()
        {
            return new Goblin();
        }
    }
}
