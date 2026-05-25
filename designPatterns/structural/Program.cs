using System;
using structural.adapter;
using structural.bridge.Materials;
using structural.bridge.Tools;
using structural.composite;
using structural.decorator;
using structural.facade;
using structural.flyweight;
using structural.proxy;

class Program 
{
    static void Main()
    {
        Console.WriteLine("---------- Adapter pattern ---------");
        Inventory inventory = new Inventory();
        
        Chicken chicken = new Chicken();
        Cow cow = new Cow();
        
        inventory.AddProduct(new ChickenAdapter(chicken));
        inventory.AddProduct(new CowAdapter(cow));

        inventory.ShowInventory();
        
        Console.WriteLine("---------- Bridge pattern ---------");
        Tool woodenAxe = new Axe(new Wood());
        Tool ironPickaxe = new Pickaxe(new Iron());
        Tool ironAxe = new Axe(new Iron());

        woodenAxe.Use();   
        ironAxe.Use(); 
        ironPickaxe.Use(); 
        
        Console.WriteLine("---------- Composite pattern ---------");
        IItem egg = new SingleItem("Poppy");
        IItem milk = new SingleItem("Honey");
        
        ItemGroup fishBundle = new ItemGroup("Bundle with fish");
        fishBundle.AddItem(new SingleItem("Catfish"));
        fishBundle.AddItem(new SingleItem("Tune"));
        fishBundle.AddItem(new SingleItem("Pike"));
        fishBundle.AddItem(new SingleItem("Octopus"));
        
        CompositeInventory Inventory1 = new CompositeInventory();
        Inventory1.AddSlot(egg);
        Inventory1.AddSlot(milk);
        Inventory1.AddSlot(fishBundle);
        
        Inventory1.ShowInfo();
        
        Console.WriteLine("---------- Decorator pattern ---------");
        ICharacterStats baseStats = new BaseStats();
        Console.WriteLine($"{baseStats.GetDescription()} | HP: {baseStats.GetHealth()}, Energy: {baseStats.GetEnergy()}");

        ICharacterStats healthBuffed = new HealthBuffFood(baseStats, 20);
        Console.WriteLine($"{healthBuffed.GetDescription()} | HP: {healthBuffed.GetHealth()}, Energy: {healthBuffed.GetEnergy()}");

        ICharacterStats energyBuffed = new EnergyBuffFood(baseStats, 30);
        Console.WriteLine($"{energyBuffed.GetDescription()} | HP: {energyBuffed.GetHealth()}, Energy: {energyBuffed.GetEnergy()}");

        ICharacterStats combinedBuffs = new EnergyBuffFood(new HealthBuffFood(baseStats, 20), 30);
        Console.WriteLine($"{combinedBuffs.GetDescription()} | HP: {combinedBuffs.GetHealth()}, Energy: {combinedBuffs.GetEnergy()}");
        
        Console.WriteLine("---------- Facade pattern ---------");
        FacadeInventory inventory2 = new FacadeInventory();
        inventory2.AddItem("honey");
        inventory2.AddItem("catfish");
        inventory2.AddItem("potato");

        Pricing pricing = new Pricing();
        Wallet wallet = new Wallet();

        MarketFacade market = new MarketFacade(inventory2, pricing, wallet);

        market.SellAllProducts();
        
        Console.WriteLine("---------- Flyweight pattern ---------");
        CropFactory factory = new CropFactory();

        var tomato = factory.GetCrop("Tomato", 7);
        var potato = factory.GetCrop("Potato", 5);
        
        var crop1 = new PlantedCrop(tomato, 1, 1, 3);
        var crop2 = new PlantedCrop(tomato, 2, 1, 4);
        var crop3 = new PlantedCrop(potato, 1, 2, 2);

        crop1.ShowInfo();
        crop2.ShowInfo();
        crop3.ShowInfo();
        
        Console.WriteLine("---------- Proxy pattern ---------");
        IAnimal cow1 = new AnimalProxy(new Cow1(), fed: true, happy: true);
        cow1.GiveProduct(); 

        IAnimal chicken1 = new AnimalProxy(new Chicken1(), fed: false, happy: true);
        chicken1.GiveProduct(); 
    }
}
