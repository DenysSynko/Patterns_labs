using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3.behavioral_patterns.template_method
{
    class ElfBattle : BattlePlan
    {
        protected override void Attack()
        {
            Console.WriteLine("Ельфи атакують точно і з дистанції ");
        }
    }
}
