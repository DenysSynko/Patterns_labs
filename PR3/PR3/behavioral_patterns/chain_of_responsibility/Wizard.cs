using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3.behavioral_patterns.chain_of_responsibility
{
    class Wizard : MiddleEarthHandler
    {
        public override void Handle(string problem)
        {
            if (problem == "магія" || problem == "Бальроґ")
            {
                Console.WriteLine("Гендальф вирішив проблему: " + problem);
            }
            else
            {
                Console.WriteLine("Навіть Гендальф не допоміг...");
            }
        }
    }
}
