using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3.behavioral_patterns.iterator
{
    class Fellowship
    {
        private List<Character> members = new List<Character>();

        public void Add(Character c)
        {
            members.Add(c);
        }

        public Iterator GetIterator()
        {
            return new Iterator(members);
        }
    }
}
