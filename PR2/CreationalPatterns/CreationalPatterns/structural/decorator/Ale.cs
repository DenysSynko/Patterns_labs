using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.structural.decorator
{
    internal class AleDrink : IDrinkable
    {
        public string GetDescription() => "Hobbit Ale";
        public double GetPrice() => 3.0;
    }
}
