using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.creational.factory_method
{
    class Orc
    {
        public string Name { get; set; }

        public void Add()
        {
            Console.WriteLine(Name + " has been added to the army.");
        }
    }
}
