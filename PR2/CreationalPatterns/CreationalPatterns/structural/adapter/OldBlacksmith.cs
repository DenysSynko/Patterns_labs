using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.structural.adapter
{
    internal class OldBlacksmith
    {
        public void ForgeSwordLegacy(string metal) 
        {
            Console.WriteLine("Anduril was forged from " + metal);
        }
    }
}
