using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3.behavioral_patterns.observer
{
    class Beacon
    {
        private List<IObserver> observers = new List<IObserver>();

        public void Subscribe(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify(string message)
        {
            foreach (var obs in observers)
            {
                obs.Update(message);
            }
        }

        public void Light()
        {
            Console.WriteLine("Вогонь запалено!");
            Notify("Сигнал тривоги!");
        }
    }
}
