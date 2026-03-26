using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.structural.flyweight
{
    internal class Ent
    {
        private int x;
        private int y;
        private bool sleeping;
        private int age;

        private EntType type;

        public Ent(int x, int y, bool sleeping, int age, EntType type)
        {
            this.x = x;
            this.y = y;
            this.sleeping = sleeping;
            this.age = age;
            this.type = type;
        }

        public void Display()
        {
            type.Display(x, y, sleeping, age);
        }
    }
}
