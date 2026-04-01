namespace creational.factory;

public class CauliflowerSeed : ISeed
{
    public string Name => "Cauliflower";
    public int GrowthTime => 12;
    
    public void Plant() => Console.WriteLine("Planting cauliflower...");
}