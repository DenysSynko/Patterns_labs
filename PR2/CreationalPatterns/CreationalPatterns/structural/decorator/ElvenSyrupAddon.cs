using CreationalPatterns.creational.abstract_factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.structural.decorator
{
    internal class ElvenSyrupAddon : DrinkDecorator
    {
        public ElvenSyrupAddon(IDrinkable drink) : base(drink) { }

        public override string GetDescription() =>
            drink.GetDescription() + " + Elven sweet syrup from Rivendell";

        public override double GetPrice() => drink.GetPrice() + 2.5;
    }
}
