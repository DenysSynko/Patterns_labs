using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3.behavioral_patterns.mediator
{
    interface IMessenger
    {
        void SendReport(string message, Subject sender);
    }
}
