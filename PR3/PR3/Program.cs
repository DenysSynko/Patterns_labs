using PR3.behavioral_patterns.chain_of_responsibility;
using PR3.behavioral_patterns.command;
using PR3.behavioral_patterns.iterator;
using PR3.behavioral_patterns.mediator;
using PR3.behavioral_patterns.memento;
using PR3.behavioral_patterns.observer;
using PR3.behavioral_patterns.state;
using PR3.behavioral_patterns.strategy;
using PR3.behavioral_patterns.template_method;
using PR3.behavioral_patterns.visitor;
using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        Console.WriteLine("------Chain of responsibility------");
        var hobbit = new Hobbit();
        var elf = new Elf();
        var wizard = new Wizard();

        
        hobbit.SetNext(elf);
        elf.SetNext(wizard);

        hobbit.Handle("припаси");
        Console.WriteLine();

        hobbit.Handle("лучник");
        Console.WriteLine();

        hobbit.Handle("Бальроґ");
        Console.WriteLine();

        hobbit.Handle("дракон");
        Console.WriteLine("------Commandor------");
        var legolas = new Legolas();
        var aragorn = new Aragorn();
        var gimli = new Gimli();

        var commander = new Commander();

        
        commander.AddOrder(new ScoutCommand(legolas));
        commander.AddOrder(new AttackCommand(aragorn));
        commander.AddOrder(new RetreatCommand(gimli));

       
        commander.ExecuteOrders();
        Console.WriteLine("------Iterator------");
        var fellowship = new Fellowship();

        fellowship.Add(new Character("Фродо"));
        fellowship.Add(new Character("Сем"));
        fellowship.Add(new Character("Арагорн"));
        fellowship.Add(new Character("Леголас"));
        fellowship.Add(new Character("Гімлі"));

        var iterator = fellowship.GetIterator();

        while (iterator.HasNext())
        {
            var character = iterator.Next();
            Console.WriteLine(character.Name + " отримує наказ рухатись вперед");
        }
        Console.WriteLine("------Mediator------");
        var king = new King();
        var steward = new StewardOfGondor();
        steward.King = king;

        var ranger = new Subject("Рейнджер Півночі", steward);
        var elfScout = new Subject("Ельф-розвідник", steward);
        var guard = new Subject("Вартовий Мінас-Тіріта", steward);

        ranger.Report("Спокій на кордонах Арнору");
        Console.WriteLine();

        elfScout.Report("Помічено рух орків біля Мордору");
        Console.WriteLine();

        guard.Report("Торговий караван прибув у місто");
        Console.WriteLine("------Memento------");
        var frodo = new Frodo();
        var gandalf = new Gandalf();

        frodo.Fatigue = 10;
        frodo.RingInfluence = 5;

        frodo.ShowState();

       
        gandalf.SaveState(frodo);

      
        frodo.Fatigue = 80;
        frodo.RingInfluence = 90;

        frodo.ShowState();

    
        gandalf.RestoreState(frodo);

        frodo.ShowState();
        Console.WriteLine("------Observer------");
        var beacon = new Beacon();

        var rohan = new Fortress("Рохан");
        var minasTirith = new Fortress("Мінас-Тіріт");

        beacon.Subscribe(rohan);
        beacon.Subscribe(minasTirith);

        beacon.Light();
        Console.WriteLine("------State------");
        var frodoB = new FrodoB(new NormalState());

        frodoB.Act();
        frodoB.Act();
        frodoB.Act();
        frodoB.Act();
        Console.WriteLine("------Strategy------");
        var commander0 = new Commander0();

        commander0.SetStrategy(new ArcherAttack());
        commander0.Attack();

        commander0.SetStrategy(new MeleeAttack());
        commander0.Attack();

        commander0.SetStrategy(new StealthAttack());
        commander0.Attack();
        Console.WriteLine("------Template method------");
        BattlePlan orcs = new OrcBattle();
        orcs.ExecutePlan();

        Console.WriteLine();

        BattlePlan elves = new ElfBattle();
        elves.ExecutePlan();
        Console.WriteLine("------Visitor------");
        var units = new List<IUnit>
        {
            new Archer(),
            new Warrior()
        };

        var inspector = new InspectionVisitor();
        var trainer = new TrainingVisitor();

        foreach (var unit in units)
        {
            unit.Accept(inspector);
        }

        Console.WriteLine();

        foreach (var unit in units)
        {
            unit.Accept(trainer);
        }
    }
}