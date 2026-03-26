using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.structural.proxy
{
    internal class PalantirProxy :IPalantir
    {
        private Palantir palantir;

        private HashSet<string> allowed = new HashSet<string>
        {
            "Gandalf",
            "Aragorn",
            "Saruman" 
        };

        public void ShowVision(string userName)
        {
            Console.WriteLine($"Access attempt: {userName}");

            if (!allowed.Contains(userName))
            {
                Console.WriteLine($"Access is restricted to {userName}. The Palantir refused him.");
                return;
            }

            if (palantir == null)
            {
                palantir = new Palantir();
            }

            Console.WriteLine($"Access granted. Showing the vision...");
            palantir.ShowVision(userName);
        }
    }
}
