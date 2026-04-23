using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3.behavioral_patterns.visitor
{
    class TrainingVisitor : IVisitor
    {
        public void Visit(Archer archer)
        {
            Console.WriteLine("Тренування точності лучника");
        }

        public void Visit(Warrior warrior)
        {
            Console.WriteLine("Тренування сили воїна");
        }
    }
}
