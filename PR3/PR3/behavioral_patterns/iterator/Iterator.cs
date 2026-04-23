using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3.behavioral_patterns.iterator
{
    class Iterator
    {
        private List<Character> collection;
        private int position = 0;

        public Iterator(List<Character> collection)
        {
            this.collection = collection;
        }

        public bool HasNext()
        {
            return position < collection.Count;
        }

        public Character Next()
        {
            return collection[position++];
        }
    }
}
