using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3.behavioral_patterns.chain_of_responsibility
{
    class Elf : MiddleEarthHandler
    {
        public override void Handle(string problem)
        {
            if (problem == "лучник" || problem == "розвідка")
            {
                Console.WriteLine("Ельф вирішив проблему: " + problem);
            }
            else if (next != null)
            {
                Console.WriteLine("Ельф не може... передає далі");
                next.Handle(problem);
            }
        }
    }
}
