using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3.behavioral_patterns.state
{
    class CorruptedState : IState
    {
        public void Act(FrodoB context)
        {
            Console.WriteLine("Перстень захоплює Фродо...");

            
            context.SetState(new NormalState());
        }
    }
}
