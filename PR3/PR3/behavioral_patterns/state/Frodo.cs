using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3.behavioral_patterns.state
{
    class FrodoB
    {
        private IState state;

        public FrodoB(IState initialState)
        {
            state = initialState;
        }

        public void SetState(IState newState)
        {
            state = newState;
        }

        public void Act()
        {
            state.Act(this);
        }
    }
}
