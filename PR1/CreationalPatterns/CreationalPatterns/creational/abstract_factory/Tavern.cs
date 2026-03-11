using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.creational.abstract_factory
{
    internal class Tavern
    {
        private IFood food;
        private IDrink drink;

        public Tavern (ITavern factory)
        {
            food = factory.CreateFood();
            drink = factory.CreateDrink();
        }

        public void Serve() { food.Eat(); drink.Drink(); }
    }
}
