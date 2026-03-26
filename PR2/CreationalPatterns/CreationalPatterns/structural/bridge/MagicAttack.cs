using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.structural.bridge
{
    internal class MagicAttack : IAttack
    {
        public void PerformAttack(string weaponName)
        {
            Console.WriteLine($"{weaponName} emits a glowing magical beam!");
        }
    }
}
