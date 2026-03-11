using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.creational.abstract_factory
{
    internal class ElvenFactory : ITavern
    {
        public IFood CreateFood()
        {
            return new ElvenLembas();
        }
        public IDrink CreateDrink() 
        {
            return new ElvenWine();
        }

    }
}
