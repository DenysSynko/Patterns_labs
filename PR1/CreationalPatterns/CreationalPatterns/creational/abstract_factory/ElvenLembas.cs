using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.creational.abstract_factory
{
    internal class ElvenLembas : IFood
    {
        public void Eat() { Console.WriteLine("Eating elven lembas bread."); }
    }
}
