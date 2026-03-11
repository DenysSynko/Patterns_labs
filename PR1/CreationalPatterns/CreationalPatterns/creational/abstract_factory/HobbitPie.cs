using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.creational.abstract_factory
{
    internal class HobbitPie : IFood
    {
        public void Eat() { Console.WriteLine("Eating a delicious hobbit pie."); }
    }
}
