using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3.behavioral_patterns.observer
{
    class Fortress : IObserver
    {
        public string Name { get; }

        public Fortress(string name)
        {
            Name = name;
        }

        public void Update(string message)
        {
            Console.WriteLine($"{Name} отримала сигнал: {message}");
        }
    }
}
