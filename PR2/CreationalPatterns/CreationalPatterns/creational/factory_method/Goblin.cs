using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.creational.factory_method
{
    internal class Goblin : Orc
    {
        public override void Add()
        {
            Console.WriteLine("Goblin has been added to the army.");
        }
    }
}
