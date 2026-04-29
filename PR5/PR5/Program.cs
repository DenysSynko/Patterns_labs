using CreationalPatterns.creational.factory_method;
using PR3.behavioral_patterns.strategy;
using PR5.decorator;
using System.Text;
using System.Threading;

class Program
{
    static void ExecuteAround(Action action)
    {
        Before();

        try
        {
            action();
        }
        finally
        {
            After();
        }
    }

    static void Before()
    {
        Console.WriteLine("Elrond opens the council chamber.");
        Console.WriteLine("The torches are lit.");
        Console.WriteLine("The guests are arriving.");
        Console.WriteLine();
    }

    static void After()
    {
        Console.WriteLine();
        Console.WriteLine("The meeting is over.");
        Console.WriteLine("The hall is closing.");
    }
    static Drink HoneyAddon(Drink drink)
    {
        return new Drink
        {
            Description = drink.Description + " + honey from Beorn's bees",
            Price = drink.Price + 1.0
        };
    }

    static Drink GingerAddon(Drink drink)
    {
        return new Drink
        {
            Description = drink.Description + " + spicy ginger from Lake City",
            Price = drink.Price + 1.5
        };
    }

    static Drink BreeHerbsAddon(Drink drink)
    {
        return new Drink
        {
            Description = drink.Description + " + select herbs from Brie",
            Price = drink.Price + 0.8
        };
    }

    static Drink ElvenSyrupAddon(Drink drink)
    {
        return new Drink
        {
            Description = drink.Description + " + Elven sweet syrup from Rivendell",
            Price = drink.Price + 2.5
        };
    }

    static Orc AddOrc(Func<Orc> factory)
    {
        Orc orc = factory();
        orc.Add();
        return orc;
    }
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        bool prog = true;
        while (prog)
        {
            Console.WriteLine("======================================");
            Console.WriteLine("             0 - EXIT");
            Console.WriteLine("          1 - Decorator");
            Console.WriteLine("    2 - Factory Method (Orc Army)");
            Console.WriteLine("          3 - Strategy");
            Console.WriteLine("        4 - Execute around");
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
                    Console.WriteLine("---Decorator---");
                    Drink drink = new Drink
                    {
                        Description = "Hobbit Ale",
                        Price = 3.0
                    };

                    drink = HoneyAddon(drink);
                    drink = BreeHerbsAddon(drink);
                    drink = GingerAddon(drink);

                    Console.WriteLine(drink.Description);
                    Console.WriteLine("Price: " + drink.Price + " silver coins");

                    Drink elfMead = new Drink
                    {
                        Description = "Mead from Shir",
                        Price = 4.0
                    };

                    elfMead = ElvenSyrupAddon(elfMead);

                    Console.WriteLine();
                    Console.WriteLine(elfMead.Description);
                    Console.WriteLine("Price: " + elfMead.Price + " silver coins");
                    break;
                case 2:
                    Console.WriteLine("---Factory_Method---");
                    Func<Orc> goblinFactory =
                        () => new Orc { Name = "Goblin" };

                    Func<Orc> urukFactory =
                        () => new Orc { Name = "Uruk-Hai" };

                    Func<Orc> mordorFactory =
                        () => new Orc { Name = "Mordor Orc" };

                    Orc orc1 = AddOrc(goblinFactory);
                    Orc orc2 = AddOrc(urukFactory);
                    Orc orc3 = AddOrc(mordorFactory);
                    break;
                case 3:
                    Console.WriteLine("---Strategy---");
                    var commander0 = new Commander0();

                    commander0.SetStrategy(() =>
                        Console.WriteLine("Archers are firing at the fortress"));
                    commander0.Attack();

                    commander0.SetStrategy(() =>
                        Console.WriteLine("The infantry launches a frontal assault"));
                    commander0.Attack();

                    commander0.SetStrategy(() =>
                        Console.WriteLine("The unit sneaks into the fortress unnoticed"));
                    commander0.Attack();
                    break;
                case 4:
                    Console.WriteLine("---Execute_around---");
                    ExecuteAround(() =>
                    {
                        Console.WriteLine("Frodo takes the Ring.");
                    });

                    Console.WriteLine();

                    ExecuteAround(() =>
                    {
                        Console.WriteLine("Aragorn consults with Gandalf.");
                    });
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

