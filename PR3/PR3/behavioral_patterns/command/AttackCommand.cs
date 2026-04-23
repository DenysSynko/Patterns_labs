using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3.behavioral_patterns.command
{
    class AttackCommand : ICommand
    {
        private Aragorn aragorn;

        public AttackCommand(Aragorn a)
        {
            aragorn = a;
        }

        public void Execute()
        {
            aragorn.LeadAttack();
        }
    }
}
