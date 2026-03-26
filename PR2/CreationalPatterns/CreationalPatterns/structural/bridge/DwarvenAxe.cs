using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.structural.bridge
{
    internal class DwarvenAxe : Weapon
    {
        public DwarvenAxe(IAttack attack) : base(attack) { }

        public override void Use()
        {
            attack.PerformAttack("Dwarven axe");
        }
    }
}
