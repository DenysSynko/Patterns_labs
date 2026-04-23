using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3.behavioral_patterns.mediator
{
    class King
    {
        public void Receive(string message)
        {
            Console.WriteLine("Король отримав важливу інформацію:");
            Console.WriteLine("" + message);
        }
    }
}
