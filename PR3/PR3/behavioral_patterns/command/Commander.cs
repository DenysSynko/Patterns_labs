using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3.behavioral_patterns.command
{
    class Commander
    {
        private Queue<ICommand> orders = new Queue<ICommand>();

        public void AddOrder(ICommand command)
        {
            orders.Enqueue(command);
        }

        public void ExecuteOrders()
        {
            while (orders.Count > 0)
            {
                ICommand cmd = orders.Dequeue();
                cmd.Execute();
            }
        }
    }
}
