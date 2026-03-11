using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.creational.factory_method
{
    internal class MordorOrc : Orc    
    {
        public override void Add()
        {
            Console.WriteLine("Mordor Orc has been added to the army.");
        }
    }
}
