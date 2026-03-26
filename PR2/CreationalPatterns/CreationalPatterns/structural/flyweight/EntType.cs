using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.structural.flyweight
{
    internal class EntType
    {
        public string Name { get; }
        public string BarkTexture { get; }
        public string LeafColor { get; }

        public EntType(string name, string barkTexture, string leafColor)
        {
            Name = name;
            BarkTexture = barkTexture;
            LeafColor = leafColor;
        }

        public void Display(int x, int y, bool sleeping, int age)
        {
            Console.WriteLine(
                $"{Name} is standing at ({x}, {y}). Texture: {BarkTexture}, " +
                $"Leaves: {LeafColor}, Sleeping: {sleeping}, Age: {age} years.");
        }
    }
}
