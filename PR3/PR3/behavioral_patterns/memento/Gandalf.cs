using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3.behavioral_patterns.memento
{
    class Gandalf
    {
        private FrodoMemento savedState;

        public void SaveState(Frodo frodo)
        {
            savedState = frodo.Save();
            Console.WriteLine("Гендальф зберіг стан Фродо");
        }

        public void RestoreState(Frodo frodo)
        {
            frodo.Restore(savedState);
            Console.WriteLine("Гендальф відновив стан Фродо");
        }
    }
}
