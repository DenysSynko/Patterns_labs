using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.creational.factory_method
{
    internal class MordorOrcCreator : Creator
    {
        public override Orc CreateOrc()
        {
            return new MordorOrc();
        }
    }
}
