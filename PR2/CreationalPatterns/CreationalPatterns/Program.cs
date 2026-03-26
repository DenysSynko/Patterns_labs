using CreationalPatterns.creational.abstract_factory;
using CreationalPatterns.creational.builder;
using CreationalPatterns.creational.factory;
using CreationalPatterns.creational.factory_method;
using CreationalPatterns.creational.prototype;
using CreationalPatterns.creational.singleton;
using CreationalPatterns.structural.adapter;
using CreationalPatterns.structural.bridge;
using CreationalPatterns.structural.composite;
using CreationalPatterns.structural.decorator;
using CreationalPatterns.structural.facade;
using CreationalPatterns.structural.flyweight;
using CreationalPatterns.structural.proxy;
using System;

class Program
{
    static void Main()
    {

        bool prog = true;  
        while (prog) {
            Console.WriteLine("Choose the patterns type: ");
            Console.WriteLine("======================================");
            Console.WriteLine("             0 - EXIT");
            Console.WriteLine("          1 - Creational");
            Console.WriteLine("          2 - Structural");
            Console.WriteLine("======================================");
            int patternType = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (patternType) {
            case 0:
                    prog = false;
                    break;
            case 1:
                    Console.WriteLine("======================================");
                    Console.WriteLine("             0 - EXIT");
                    Console.WriteLine("      1 - Singleton (One Ring)");
                    Console.WriteLine("      2 - Prototype (Warrior)");
                    Console.WriteLine("      3 - Builder (Two armies)");
                    Console.WriteLine("     4 - Factory (Prancing Pony)");
                    Console.WriteLine("    5 - Factory Method (Orc Army)");
                    Console.WriteLine("    6 - Abstract Factory (Tavern)");
                    Console.WriteLine("======================================");
                    Console.Write("Choose the pattern: ");
                    int pattern = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (pattern)
                    {
                        case 0:
                            prog = false;
                            break;
                        case 1:
                            Console.WriteLine("---Singleton---");
                            OneRing ring1 = OneRing.GetOneRing();
                            OneRing ring2 = OneRing.GetOneRing();

                            if (ring1 == ring2)
                            {
                                ring1.Read();
                            }
                            break;
                        case 2:
                            Console.WriteLine("---Prototype---");
                            Warrior man1 = new Warrior("dunedain", "ancient, westron", "ranger", "sword");
                            Warrior man2 = (Warrior)man1.Clone();
                            Console.Write("Description of a warrior: ");
                            man1.Show();
                            Console.Write("Description of a warrior clone: ");
                            man2.Show();
                            break;
                        case 3:
                            Console.WriteLine("---Builder---");
                            Console.WriteLine("First army");
                            Console.WriteLine("Enter the number of cavalry, infantry, guards, fortress guards, archers: ");
                            int?[] line = Console.ReadLine().Split(" ").Select(x => (int?)int.Parse(x)).ToArray();
                            for (int i = 0; i < 5; i++)
                            {
                                if (line[i] < 1) line[i] = null;
                            }
                            ArmyOfGondor army1 = new ArmyBuilder()
                                .SetCavalry(line[0])
                                .SetInfantry(line[1])
                                .SetGuard(line[2])
                                .SetFortressGuard(line[3])
                                .SetArchers(line[4])
                                .Build();
                            Console.WriteLine("Second army");
                            Console.WriteLine("Enter the number of cavalry, infantry, guards, fortress guards, archers: ");
                            int?[] line2 = Console.ReadLine().Split(" ").Select(x => (int?)int.Parse(x)).ToArray();
                            for (int i = 0; i < 5; i++)
                            {
                                if (line2[i] < 1) line2[i] = null;
                            }
                            ArmyOfGondor army2 = new ArmyBuilder()
                                .SetCavalry(line2[0])
                                .SetInfantry(line2[1])
                                .SetGuard(line2[2])
                                .SetFortressGuard(line2[3])
                                .SetArchers(line2[4])
                                .Build();
                            Console.WriteLine("_Army 1_");
                            army1.Show();
                            Console.WriteLine("_Army 2_");
                            army2.Show();
                            break;
                        case 4:
                            Console.WriteLine("---Factory---");
                            MenuFactory menu = new MenuFactory();
                            Console.WriteLine("Menu");
                            Console.WriteLine("----");
                            Console.WriteLine("Ale");
                            Console.WriteLine("Beer");
                            Console.WriteLine("Wine");
                            Console.WriteLine("Coffee");
                            Console.WriteLine("Tea");
                            Console.WriteLine("----");
                            Console.WriteLine("Welcome to the \"Prancing Pony\"");
                            while (true)
                            {
                                Console.Write("Please, place an order: ");
                                string orderLine = Console.ReadLine();
                                IMenu order = menu.CreateOrder(orderLine);
                                Console.Write("\"The waiter pours ");
                                order.place();
                                Console.WriteLine(".\"");
                                Console.Write("Something else? (y/n): ");
                                string elseLine = Console.ReadLine();
                                if (elseLine.ToLower() != "y") break;
                            }
                            break;
                        case 5:
                            Console.WriteLine("---Factory_Method---");
                            Creator creator;
                            creator = new GoblinCreator();
                            Orc orc1 = creator.AddOrc();
                            creator = new UrukHaiCreator();
                            Orc orc2 = creator.AddOrc();
                            creator = new MordorOrcCreator();
                            Orc orc3 = creator.AddOrc();
                            break;
                        case 6:
                            Console.WriteLine("---Abstract_Factory---");
                            ITavern factory;
                            Console.Write("Do you want hobbit or elf food?: ");
                            string foodChoice = Console.ReadLine();
                            if (foodChoice.ToLower() == "elf")
                            {
                                factory = new ElvenFactory();
                                Tavern tavern = new Tavern(factory);
                                tavern.Serve();

                            }
                            else if (foodChoice == "hobbit")
                            {
                                factory = new HobbitFactory();
                                Tavern tavern = new Tavern(factory);
                                tavern.Serve();
                            }
                            else
                            {
                                Console.WriteLine("Error");
                            }
                            break;
                        default:
                            Console.WriteLine("Error");
                            break;

                    }
                    break;
            case 2:
                    Console.WriteLine("======================================");
                    Console.WriteLine("             0 - EXIT");
                    Console.WriteLine("      1 - Adapter");
                    Console.WriteLine("      2 - Bridge");
                    Console.WriteLine("      3 - Composit");
                    Console.WriteLine("     4 - Decorator");
                    Console.WriteLine("    5 - Facade");
                    Console.WriteLine("    6 - Flyweight");
                    Console.WriteLine("    7 - Proxy");
                    Console.WriteLine("======================================");
                    Console.Write("Choose the pattern: ");
                    int pattern2 = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (pattern2)
                    {
                        case 0:
                            prog = false;
                            break;
                        case 1:
                            Console.WriteLine("---Adapter---");
                            OldBlacksmith blacksmith = new OldBlacksmith();
                            ISword swordFactory = new RivendellBlacksmith(blacksmith);
                            swordFactory.CreateSword();
                            break;
                        case 2:
                            Console.WriteLine("---Bridge---");
                            Weapon gandalfSword = new ElvenSword(new MagicAttack());
                            gandalfSword.Use();
                            Weapon gimliAxe = new DwarvenAxe(new PhysicalAttack());
                            gimliAxe.Use();
                            Weapon orcBow = new OrcishBow(new FireAttack());
                            orcBow.Use();

                            break;
                        case 3:
                            Console.WriteLine("---Composite---");
                            var mordorArmy = new ArmyGroup("The Army of Mordor");

                            mordorArmy.Add(new OrcUnit());
                            mordorArmy.Add(new OrcUnit());
                            mordorArmy.Add(new TrollUnit());

                            var nazgulGroup = new ArmyGroup("The Ring of the Nine Nazgûl");
                            for (int i = 0; i < 9; i++) nazgulGroup.Add(new NazgulUnit());

                            mordorArmy.Add(nazgulGroup);

                            var dolGuldurArmy = new ArmyGroup("The Army of Dol Guldur");
                            dolGuldurArmy.Add(new GoblinUnit());
                            dolGuldurArmy.Add(new GoblinUnit());
                            dolGuldurArmy.Add(new TrollUnit());

                            mordorArmy.Add(dolGuldurArmy);

                            mordorArmy.Display();
                            Console.WriteLine($"\nTotal strength of the army: {mordorArmy.GetStrength()}");
                            break;
                        case 4:
                            Console.WriteLine("---Decorator---");
                            IDrinkable drink = new AleDrink();

                            drink = new HoneyAddon(drink);
                            drink = new BreeHerbsAddon(drink);
                            drink = new GingerAddon(drink);

                            Console.WriteLine(drink.GetDescription());
                            Console.WriteLine("Price: " + drink.GetPrice() + " silver coins");

                            IDrinkable elfMead = new ElvenSyrupAddon(new MeadDrink());
                            Console.WriteLine("\n" + elfMead.GetDescription());
                            Console.WriteLine("Price: " + elfMead.GetPrice() + " silver coins");
                            break;
                        case 5:
                            Console.WriteLine("---Facade---");
                            FellowshipFacade fellowship = new FellowshipFacade();
                            fellowship.PrepareJourney();
                            break;
                        case 6:
                            Console.WriteLine("---Flyweight---");
                            var factory = new EntFactory();
                            var forest = new List<Ent>();

                            var oakEnt = factory.GetEntType("oak-Ent", "rough bark", "dark green");
                            var ashEnt = factory.GetEntType("ash-Ent", "light-colored bark", "bright green");
                            var pineEnt = factory.GetEntType("pine-Ent", "smooth bark", "dark pine needles");

                            var rand = new Random();

                            for (int i = 0; i < 10; i++)
                            {
                                var type = (i % 3) switch
                                {
                                    0 => oakEnt,
                                    1 => ashEnt,
                                    _ => pineEnt
                                };

                                forest.Add(new Ent(
                                    x: rand.Next(0, 100),
                                    y: rand.Next(0, 100),
                                    sleeping: rand.Next(0, 2) == 0,
                                    age: rand.Next(50, 500),
                                    type: type
                                ));
                            }

                            foreach (var ent in forest) ent.Display();
                            break;
                        case 7:
                            Console.WriteLine("---Proxy---");
                            IPalantir palantir = new PalantirProxy();

                            palantir.ShowVision("Pippin");
                            Console.WriteLine();
                            palantir.ShowVision("Gandalf");
                            Console.WriteLine();
                            palantir.ShowVision("Aragorn");
                            break;
                        default:
                            Console.WriteLine("Error");
                            break;

                    }
                    break;
            default:
                    break;
            }

            
            Console.WriteLine("\nPress any key ...");
            Console.ReadLine();
            Console.Clear();
        }
        
        
    }
}
