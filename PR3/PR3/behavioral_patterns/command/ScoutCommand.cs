using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3.behavioral_patterns.command
{
    class ScoutCommand : ICommand
    {
        private Legolas legolas;

        public ScoutCommand(Legolas l)
        {
            legolas = l;
        }

        public void Execute()
        {
            legolas.Scout();
        }
    }
}
