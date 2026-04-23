using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3.behavioral_patterns.command
{
    class RetreatCommand : ICommand
    {
        private Gimli gimli;

        public RetreatCommand(Gimli g)
        {
            gimli = g;
        }

        public void Execute()
        {
            gimli.CoverRetreat();
        }
    }
}
