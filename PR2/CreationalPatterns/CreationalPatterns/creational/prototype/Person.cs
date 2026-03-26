using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.creational.prototype
{
    internal abstract class Person
    {
        public abstract Person Clone();
    }
}
