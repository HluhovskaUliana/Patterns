using creational.factory;
using creational.singleton;

class Program
{
    static void Main()
    {
        Console.WriteLine("---------- singleton pattern ---------");
        InventoryManager backpack = InventoryManager.Instance; 
        InventoryManager backpack2 = InventoryManager.Instance; 
        
        Console.WriteLine(Object.ReferenceEquals(backpack, backpack2)); // це один і той самий рюкзак, повторне створення неможливе
        
        Console.WriteLine("---------- factory pattern ---------");
        var factory = new SeedFactory();

        ISeed seedА = factory.Create(SeedType.Cauliflower);
        seedА.Plant();
        
        ISeed seedB = factory.Create(SeedType.Parsnip);
        seedB.Plant();
        
        Console.WriteLine("---------- pattern ---------");
    }
}