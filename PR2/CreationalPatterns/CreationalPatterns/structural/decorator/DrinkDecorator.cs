using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.structural.decorator
{
    internal abstract class DrinkDecorator : IDrinkable
    {
        protected IDrinkable drink;

        public DrinkDecorator(IDrinkable drink)
        {
            this.drink = drink;
        }

        public virtual string GetDescription() => drink.GetDescription();
        public virtual double GetPrice() => drink.GetPrice();
    }
}
