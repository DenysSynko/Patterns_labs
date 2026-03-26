using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.structural.decorator
{
    internal class MeadDrink : IDrinkable
    {
        public string GetDescription() => "Mead from Shir";
        public double GetPrice() => 4.0;
    }
}
