using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3.behavioral_patterns.state
{
    class TiredState : IState
    {
        public void Act(FrodoB context)
        {
            Console.WriteLine("Фродо виснажений і ледве йде");

            
            context.SetState(new CorruptedState());
        }
    }
}
