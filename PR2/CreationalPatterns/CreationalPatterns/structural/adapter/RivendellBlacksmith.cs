using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.structural.adapter
{
    internal class RivendellBlacksmith : ISword
    {
        private OldBlacksmith blacksmith;
        public RivendellBlacksmith(OldBlacksmith blacksmith) 
        {
            this.blacksmith = blacksmith; 
        }

        public void CreateSword() 
        {
            blacksmith.ForgeSwordLegacy("Narsil fragments.");
        }
    }
}
