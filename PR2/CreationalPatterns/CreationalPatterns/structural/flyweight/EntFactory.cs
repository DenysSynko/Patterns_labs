using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.structural.flyweight
{
    internal class EntFactory
    {
        private Dictionary<string, EntType> types = new();

        public EntType GetEntType(string name, string texture, string leafColor)
        {
            if (!types.ContainsKey(name))
            {
                types[name] = new EntType(name, texture, leafColor);
            }

            return types[name];
        }
    }
}
