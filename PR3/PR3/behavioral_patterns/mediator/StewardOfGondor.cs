using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3.behavioral_patterns.mediator
{
    class StewardOfGondor : IMessenger
    {
        public King King { get; set; }

        public void SendReport(string message, Subject sender)
        {
            Console.WriteLine($"Радник отримав звіт від {sender.Name}: {message}");

            
            if (message.Contains("Мордор") ||
                message.Contains("армія") ||
                message.Contains("ворог") ||
                message.Contains("Перстень"))
            {
                Console.WriteLine("Радник терміново доповідає королю!");
                King.Receive(message);
            }
            else
            {
                Console.WriteLine("Радник вирішує, що це не критично і не турбує короля");
            }
        }
    }
}
