using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.structural.decorator
{
    internal class HoneyAddon : DrinkDecorator
    {
        public HoneyAddon(IDrinkable drink) : base(drink) { }

        public override string GetDescription() =>
            drink.GetDescription() + " + honey from Beorn's bees";

        public override double GetPrice() => drink.GetPrice() + 1.0;
    }
}
