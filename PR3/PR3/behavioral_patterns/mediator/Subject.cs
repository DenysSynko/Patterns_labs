using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3.behavioral_patterns.mediator
{
    class Subject
    {
        private IMessenger mediator;
        public string Name { get; }

        public Subject(string name, IMessenger mediator)
        {
            Name = name;
            this.mediator = mediator;
        }

        public void Report(string message)
        {
            Console.WriteLine($"{Name}: {message}");
            mediator.SendReport(message, this);
        }
    }
}
