using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.structural.decorator
{
    internal interface IDrinkable
    {
        string GetDescription();
        double GetPrice();
    }
}
