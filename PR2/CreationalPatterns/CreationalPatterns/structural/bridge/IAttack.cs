using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.structural.bridge
{
    internal interface IAttack
    {
        void PerformAttack(string weaponName);
    }
}
