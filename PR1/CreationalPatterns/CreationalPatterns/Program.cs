using CreationalPatterns.creational.prototype;
using CreationalPatterns.creational.singleton;
using CreationalPatterns.creational.builder;
using System;
using CreationalPatterns.creational.factory;
using CreationalPatterns.creational.factory_method;
using CreationalPatterns.creational.abstract_factory;

class Program
{
    static void Main()
    {
        bool prog = true;  
        while (prog) {
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
                    for(int i = 0; i<5; i++) 
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
                        if(elseLine.ToLower() != "y") break;
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
                    if(foodChoice.ToLower() == "elf")
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
            Console.WriteLine("Press any key ...");
            Console.ReadLine();
            Console.Clear();
        }
        
        
    }
}
