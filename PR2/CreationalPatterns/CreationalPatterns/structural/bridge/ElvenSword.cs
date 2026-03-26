using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.structural.bridge
{
    internal class ElvenSword : Weapon
    {
        public ElvenSword(IAttack attack) : base(attack) { }

        public override void Use()
        {
            attack.PerformAttack("Elven sword");
        }
    }
}
