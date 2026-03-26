using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.structural.bridge
{
    internal class FireAttack : IAttack
    {
        public void PerformAttack(string weaponName)
        {
            Console.WriteLine($"{weaponName} blazes with the flames of Moria!");
        }
    }
}
