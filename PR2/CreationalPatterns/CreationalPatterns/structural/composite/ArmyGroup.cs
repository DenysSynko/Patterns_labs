using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.structural.composite
{
    internal class ArmyGroup : IArmyUnit
    {
        private string name;
        private List<IArmyUnit> units = new List<IArmyUnit>();

        public ArmyGroup(string name)
        {
            this.name = name;
        }

        public void Add(IArmyUnit unit)
        {
            units.Add(unit);
        }

        public void Remove(IArmyUnit unit)
        {
            units.Remove(unit);
        }

        public void Display(int gap = 0)
        {
            Console.WriteLine(new string(' ', gap) + name);

            foreach (var unit in units)
            {
                unit.Display(gap + 2);
            }
        }

        public int GetStrength()
        {
            int total = 0;
            foreach (var unit in units)
                total += unit.GetStrength();

            return total;
        }
    }
}
