using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3.behavioral_patterns.visitor
{
    class Warrior : IUnit
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
