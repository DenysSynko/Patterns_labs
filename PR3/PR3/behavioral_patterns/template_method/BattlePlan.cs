using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3.behavioral_patterns.template_method
{
    abstract class BattlePlan
    {
        
        public void ExecutePlan()
        {
            GatherForces();
            Prepare();
            Attack();
            Retreat();
        }

        protected void GatherForces()
        {
            Console.WriteLine("Збір війська");
        }

        protected void Prepare()
        {
            Console.WriteLine("Підготовка до бою");
        }

        protected abstract void Attack();

        protected void Retreat()
        {
            Console.WriteLine("Відступ після бою");
        }
    }
}
