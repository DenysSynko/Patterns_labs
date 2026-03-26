using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.structural.facade
{
    internal class FellowshipFacade
    {
        private Supplies supplies;
        private Equipment equipment;
        private RoutePlanner route;
        private Transport transport;

        public FellowshipFacade()
        {
            supplies = new Supplies();
            equipment = new Equipment();
            route = new RoutePlanner();
            transport = new Transport();
        }

        public void PrepareJourney()
        {
            Console.WriteLine("=== Preparations for the Fellowship of the Ring are underway ===");

            supplies.Prepare();
            equipment.Check();
            route.BuildRoute();
            transport.PreparePonies();

            Console.WriteLine("=== The fellowship is ready to set off! ===");
        }
    }
}
