using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.structural.decorator
{
    internal class BreeHerbsAddon : DrinkDecorator
    {
        public BreeHerbsAddon(IDrinkable drink) : base(drink) { }

        public override string GetDescription() =>
            drink.GetDescription() + " + select herbs from Brie";

        public override double GetPrice() => drink.GetPrice() + 0.8;
    }
}
