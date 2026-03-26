using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.creational.abstract_factory
{
    internal interface ITavern
    {
        IFood CreateFood();
        IDrink CreateDrink();
    }
}
