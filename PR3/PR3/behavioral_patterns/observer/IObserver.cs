using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3.behavioral_patterns.observer
{
    interface IObserver
    {
        void Update(string message);
    }
}
