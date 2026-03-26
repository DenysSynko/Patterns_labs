using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.structural.bridge
{
    internal abstract class Weapon
    {
        protected IAttack attack;

        public Weapon(IAttack attack)
        {
            this.attack = attack;
        }

        public abstract void Use();
    }
}
