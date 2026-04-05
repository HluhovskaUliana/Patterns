using creational.abstractFactory;
using creational.abstractFactory.Animals;
using creational.builder;
using creational.builder.CharacterOptions;
using creational.factory;
using creational.prototype;
using creational.singleton;

class Program
{
    static void Main()
    {
        Console.WriteLine("---------- Singleton pattern ---------");
        InventoryManager backpack = InventoryManager.Instance; 
        InventoryManager backpack2 = InventoryManager.Instance; 
        
        Console.WriteLine(object.ReferenceEquals(backpack, backpack2)); // це один і той самий рюкзак, повторне створення неможливе
        
        Console.WriteLine("---------- Factory ---------");
        var factory = new SeedFactory();

        ISeed seedА = factory.Create(SeedType.Cauliflower);
        seedА.Plant();
        
        ISeed seedB = factory.Create(SeedType.Parsnip);
        seedB.Plant();
        
        Console.WriteLine("---------- Abstract factory ---------");

        var habitat = new HabitatAnimalFactory();
        
        //створення тваринок із фабрики barn 
        IAnimal cow = habitat.GetAnimalFactory(HabitatType.Barn).GetAnimal(AnimalType.Cow);
        IAnimal pig = habitat.GetAnimalFactory(HabitatType.Barn).GetAnimal(AnimalType.Pig);
        
        Console.WriteLine($"{cow.Name}: {cow.MakeSound()}");
        Console.WriteLine($"{pig.Name}: {pig.MakeSound()}");
        
        //створення тваринок із фабрики coop
        IAnimal chicken = habitat.GetAnimalFactory(HabitatType.Coop).GetAnimal(AnimalType.Chicken);
        IAnimal rabbit = habitat.GetAnimalFactory(HabitatType.Coop).GetAnimal(AnimalType.Rabbit);
        
        Console.WriteLine($"{chicken.Name}: {chicken.MakeSound()}");
        Console.WriteLine($"{rabbit.Name}: {rabbit.MakeSound()}");
        
        Console.WriteLine("---------- Builder ---------");

        Character player1 = new CharacterBuilder()
            .SetName("Alex")
            .SetHairColor(HairColorType.Indigo)
            .SetPetType(PetType.Cat)
            .SetPetName("Neko")
            .Build();

        Character defaultPlayer = new CharacterBuilder().Build();
        
        Console.WriteLine(player1.ToString());
        Console.WriteLine("----------");
        Console.WriteLine(defaultPlayer.ToString());
        
        Console.WriteLine("---------- Prototype ---------");

        var original = new GameState("Alex", 100, 500, 1);
        Console .WriteLine("Original: " + original.ToString());

        var copy = (GameState)original.DoClone();
        Console.WriteLine("Copy:" + copy.ToString());
        
        copy.Health = 60;
        copy.Day = 3;
        
        Console.WriteLine("Copy2:" + copy.ToString());
        
    }
}