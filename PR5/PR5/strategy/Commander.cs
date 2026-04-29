using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3.behavioral_patterns.strategy
{
    class Commander0
    {
        private Action strategy;

        public void SetStrategy(Action strategy)
        {
            this.strategy = strategy;
        }

        public void Attack()
        {
            strategy?.Invoke();
        }
    }
}
