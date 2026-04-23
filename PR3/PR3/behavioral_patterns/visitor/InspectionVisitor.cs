using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3.behavioral_patterns.visitor
{
    class InspectionVisitor : IVisitor
    {
        public void Visit(Archer archer)
        {
            Console.WriteLine("Перевірка лучника");
        }

        public void Visit(Warrior warrior)
        {
            Console.WriteLine("Перевірка воїна");
        }
    }
}
