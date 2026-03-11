using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.creational.factory_method
{
    internal class UrukHai : Orc
    {
        public override void Add()
        {
            Console.WriteLine("Uruc-Hai has been added to the army.");
        }
    }
}
