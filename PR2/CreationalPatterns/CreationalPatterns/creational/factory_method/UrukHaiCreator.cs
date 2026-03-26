using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.creational.factory_method
{
    internal class UrukHaiCreator : Creator
    {
        public override Orc CreateOrc()
        {
            return new UrukHai();
        }
    }
}
