using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3.behavioral_patterns.memento
{
    class FrodoMemento
    {
        public int Fatigue { get; }
        public int RingInfluence { get; }

        public FrodoMemento(int fatigue, int ringInfluence)
        {
            Fatigue = fatigue;
            RingInfluence = ringInfluence;
        }
    }
}
