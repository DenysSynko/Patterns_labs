using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.creational.builder
{
    internal interface IArmy
    {
        public ArmyBuilder SetInfantry(int? infantry);
        public ArmyBuilder SetArchers(int? archers);
        public ArmyBuilder SetCavalry(int? cavalry);
        public ArmyBuilder SetGuard(int? guard);
        public ArmyBuilder SetFortressGuard(int? fortressGuard);
    }
}
