using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.structural.bridge
{
    internal class PhysicalAttack : IAttack
    {
        public void PerformAttack(string weaponName)
        {
            Console.WriteLine($"{weaponName} delivers a powerful physical blow!");
        }
    }
}
