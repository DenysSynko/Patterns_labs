using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.creational.abstract_factory
{
    internal class HobbitFactory : ITavern
    {
        public IFood CreateFood()
        {
            return new HobbitPie();
        }
        public IDrink CreateDrink() 
        {
            return new HobbitAle();
        }
    }
}
