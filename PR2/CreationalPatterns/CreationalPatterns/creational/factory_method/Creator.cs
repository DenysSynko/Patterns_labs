using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.creational.factory_method
{
    internal abstract class Creator
    {
        public abstract Orc CreateOrc();
        
        public Orc AddOrc()
        {
            Orc orc = CreateOrc();
            orc.Add();
            return orc;
        }
    }
}
