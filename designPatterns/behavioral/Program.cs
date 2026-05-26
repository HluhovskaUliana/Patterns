using System;
using behavioral.hainOfResponsibility;
using behavioral.command;

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

        // Виконання різних команд
        farmer.SetCommand(new WaterPlantsCommand());
        farmer.ExecuteCommand();

        farmer.SetCommand(new HarvestCommand());
        farmer.ExecuteCommand();

        farmer.SetCommand(new FeedAnimalsCommand());
        farmer.ExecuteCommand();
        
        
    }
}