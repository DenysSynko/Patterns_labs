using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3.behavioral_patterns.template_method
{
    class OrcBattle : BattlePlan
    {
        protected override void Attack()
        {
            Console.WriteLine("Орки атакують хаотично і масово");
        }
    }
}
