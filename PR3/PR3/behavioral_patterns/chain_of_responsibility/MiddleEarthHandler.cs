using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3.behavioral_patterns.chain_of_responsibility
{
    abstract class MiddleEarthHandler
    {
        protected MiddleEarthHandler next;

        public void SetNext(MiddleEarthHandler handler)
        {
            next = handler;
        }

        public abstract void Handle(string problem);
    }
}
