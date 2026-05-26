using System;
using behavioral.hainOfResponsibility;
using behavioral.command;
using behavioral.iterator;
using behavioral.mediator;
using behavioral.memento;
using behavioral.observer;
using behavioral.state;
using behavioral.strategy;
using behavioral.templateMethod;
using behavioral.visitor;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("---------- Hain of Responsibility pattern ---------");
        //обробники
        var bats = new BatEventHandler();
        var meteor = new MeteorEventHandler();
        var festival = new FestivalEventHandler();
        var witch = new WitchEventHandler();
        var defaultHandler = new DefaultEventHandler();
        
        bats.SetNext(meteor);
        meteor.SetNext(festival);
        festival.SetNext(witch);
        witch.SetNext(defaultHandler);

        // Приклад контексту (ніч з метеоритом)
        NightContext context = new NightContext
        {
            HasBats = false,
            HasMeteor = true,
            HasFestival = false,
            HasWitch = false
        };
        
        bats.Handle(context);

        Console.WriteLine("---------- Command pattern ---------");
        Farmer farmer = new Farmer();
        
        farmer.SetCommand(new WaterPlantsCommand());
        farmer.ExecuteCommand();

        farmer.SetCommand(new HarvestCommand());
        farmer.ExecuteCommand();

        farmer.SetCommand(new FeedAnimalsCommand());
        farmer.ExecuteCommand();
        
        Console.WriteLine("---------- Iterator pattern ---------");
        HarvestCollection harvest = new HarvestCollection();
        harvest.AddItem("tomato");
        harvest.AddItem("corn");
        harvest.AddItem("pumpkin");
        harvest.AddItem("strawberry");

        IIterator<string> iterator = harvest.CreateIterator();

        Console.WriteLine("harvest on the farm:");
        while (iterator.HasNext())
        {
            Console.WriteLine("- " + iterator.Next());
        }
        
        Console.WriteLine("---------- Mediator pattern ---------");
        Farmer1 farmer1 = new Farmer1();
        Merchant merchant = new Merchant();
        Blacksmith blacksmith = new Blacksmith();

        TownMediator mediator = new TownMediator(farmer1, merchant, blacksmith);

        // фермер просить насіння
        farmer1.AskForSeeds();

        Console.WriteLine();

        // фермер просить ремонт інструменту
        farmer1.AskForToolRepair();

        Console.WriteLine("---------- Memento pattern ---------");
        Farm farm = new Farm();
        FarmCaretaker caretaker = new FarmCaretaker();
        
        farm.SetState("Planted tomatoes");
        caretaker.Save(farm);

        farm.SetState("Watered crops");
        caretaker.Save(farm);

        farm.SetState("Harvested pumpkins");

        Console.WriteLine("\n--- Undo actions ---");
        caretaker.Undo(farm); 
        caretaker.Undo(farm);

        Console.WriteLine("---------- Observer pattern ---------");
        Farm1 farm1 = new Farm1();

        Villager abigail = new Villager("Abigail");
        Villager sebastian = new Villager("Sebastian");
        Villager leah = new Villager("Leah");

        // Спотерігачі
        farm1.Attach(abigail);
        farm1.Attach(sebastian);
        farm1.Attach(leah);

        // дії на фермі
        farm1.Harvest();
        farm1.WaterPlants();
        
        Console.WriteLine("---------- State pattern ---------");
        // починається із стану посадки
        Farm2 farm2 = new Farm2(new PlantingState());
        
        farm2.Request(); // посаджено
        farm2.Request(); // росте
        farm2.Request(); // виросло
        farm2.Request(); // знову стан посадки
        
        Console.WriteLine("---------- Strategy pattern ---------");
        Farmer2 farmer2 = new Farmer2(new ManualHarvestStrategy());
        
        farmer2.HarvestCrop("Tomatoes");
        
        farmer2.SetStrategy(new MachineHarvestStrategy());
        farmer2.HarvestCrop("Corn");

        farmer2.SetStrategy(new MagicalHarvestStrategy());
        farmer2.HarvestCrop("Pumpkins");
        
        Console.WriteLine("---------- Template Method pattern ---------");
        FarmActivity planting = new PlantingActivity();
        planting.PerformActivity();

        FarmActivity watering = new WateringActivity();
        watering.PerformActivity();

        FarmActivity harvesting = new HarvestingActivity();
        harvesting.PerformActivity();
        
        Console.WriteLine("---------- Visitor pattern ---------");
        // Створ елементи ферми
        List<IFarmElement> farmElements = new List<IFarmElement>
        {
            new Cow(),
            new Crop()
        };

        // Відвідувачі
        IVisitor farmer4 = new FarmerVisitor();
        IVisitor trader = new TraderVisitor();

        Console.WriteLine("Farmer actions:");
        foreach (var element in farmElements)
        {
            element.Accept(farmer4);
        }

        Console.WriteLine("\nTrader actions:");
        foreach (var element in farmElements)
        {
            element.Accept(trader);
        }
    }
}