using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.creational.abstract_factory
{
    internal class ElvenWine : IDrink
    {
        public void Drink() { Console.WriteLine("Drinking elven wine."); }
    }
}
