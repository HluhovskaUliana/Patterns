using System;
using behavioral.hainOfResponsibility;
using behavioral.command;
using behavioral.iterator;
using behavioral.mediator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("---------- Hain of Responsibility pattern ---------");
        // Створюємо обробники
        var bats = new BatEventHandler();
        var meteor = new MeteorEventHandler();
        var festival = new FestivalEventHandler();
        var witch = new WitchEventHandler();
        var defaultHandler = new DefaultEventHandler();

        // Формуємо ланцюг
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
        
        Console.WriteLine("---------- mediator pattern ---------");
        Farmer1 farmer1 = new Farmer1();
        Merchant merchant = new Merchant();
        Blacksmith blacksmith = new Blacksmith();

        TownMediator mediator = new TownMediator(farmer1, merchant, blacksmith);

        // Фермер просить насіння
        farmer1.AskForSeeds();

        Console.WriteLine();

        // Фермер просить ремонт інструменту
        farmer1.AskForToolRepair();

        Console.ReadLine();
    }
}