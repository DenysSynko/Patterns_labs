using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.creational.builder
{
    internal class ArmyOfGondor
    {
        public int? Infantry { get; set; }
        public int? Archers { get; set; }
        public int? Cavalry { get; set; }
        public int? Guard { get; set; }
        public int? FortressGuard { get; set; }

        public void Show()
        {
            string army = "";
            if (Infantry.HasValue)
            {
                army += $"Infantry: {Infantry}\n";
            }
            if (Archers.HasValue)
            {
                army += $"Archers: {Archers}\n";
            }
            if (Cavalry.HasValue)
            {
                army += $"Cavalry: {Cavalry}\n";
            }
            if (Guard.HasValue)
            {
                army += $"Guard: {Guard}\n";
            }
            if (FortressGuard.HasValue)
            {
                army += $"FortressGuard: {FortressGuard}\n";
            }
            Console.WriteLine(army);
        }
    }
}
