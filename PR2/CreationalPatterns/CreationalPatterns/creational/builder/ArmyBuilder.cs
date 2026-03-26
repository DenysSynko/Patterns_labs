using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.creational.builder
{
    internal class ArmyBuilder : IArmy
    {
        public ArmyOfGondor Army = new ArmyOfGondor();  

        public ArmyBuilder SetInfantry(int? infantry) {
            Army.Infantry = infantry;
            return this;
        }
        public ArmyBuilder SetArchers(int? archers) {
            Army.Archers = archers;
            return this;
        }
        public ArmyBuilder SetCavalry(int? cavalry) {
            Army.Cavalry = cavalry;
            return this;
        }
        public ArmyBuilder SetGuard(int? guard) {
            Army.Guard = guard;
            return this;
        }
        public ArmyBuilder SetFortressGuard(int? fortressGuard) {
            Army.FortressGuard = fortressGuard;
            return this;
        }
        public ArmyOfGondor Build() => Army;
    }
}
