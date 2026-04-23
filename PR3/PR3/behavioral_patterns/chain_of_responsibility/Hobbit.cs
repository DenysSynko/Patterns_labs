using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3.behavioral_patterns.chain_of_responsibility
{
    class Hobbit : MiddleEarthHandler
    {
        public override void Handle(string problem)
        {
            if (problem == "припаси" || problem == "схованка")
            {
                Console.WriteLine("Гобіт вирішив проблему: " + problem);
            }
            else if (next != null)
            {
                Console.WriteLine("Гобіт не може... передає далі");
                next.Handle(problem);
            }
        }
    }
}
