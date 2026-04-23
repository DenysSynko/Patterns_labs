using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3.behavioral_patterns.memento
{
    class Frodo
    {
        public int Fatigue { get; set; }
        public int RingInfluence { get; set; }

        public void ShowState()
        {
            Console.WriteLine($"Фродо: втома={Fatigue}, вплив Персня={RingInfluence}");
        }

        
        public FrodoMemento Save()
        {
            return new FrodoMemento(Fatigue, RingInfluence);
        }

        
        public void Restore(FrodoMemento memento)
        {
            Fatigue = memento.Fatigue;
            RingInfluence = memento.RingInfluence;
        }
    }
}
