using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.creational.singleton
{
    internal class OneRing
    {
        private static OneRing? ring;
        private OneRing() { 
            Console.WriteLine("One Ring has been created.");
        }
        public static OneRing GetOneRing() {
            if (ring == null)
            {
                ring = new OneRing();
            }
            return ring;
        }
        public void Read() {
            Console.WriteLine("One ring to rule them all, one ring to find them,\r\nOne ring to bring them all and in the darkness bind them.");
        }
    }
}
