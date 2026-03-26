using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.creational.factory
{
    internal class Ale : IMenu
    {
        public void place() 
        {
            Console.Write("ale");
        }
    }
}
