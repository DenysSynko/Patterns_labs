using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.structural.proxy
{
    internal class Palantir : IPalantir
    {
        public Palantir()
        {
            Console.WriteLine("The fog lifts from the Palantir...");
        }

        public void ShowVision(string userName)
        {
            Console.WriteLine($"The Palantir shows a vision to the user {userName}...");
        }
    }
}
