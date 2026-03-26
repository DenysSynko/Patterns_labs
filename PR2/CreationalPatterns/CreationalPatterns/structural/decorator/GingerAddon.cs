using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.structural.decorator
{
    internal class GingerAddon : DrinkDecorator
    {
        public GingerAddon(IDrinkable drink) : base(drink) { }

        public override string GetDescription() =>
            drink.GetDescription() + " + spicy ginger from Lake City";

        public override double GetPrice() => drink.GetPrice() + 1.5;
    }
}
