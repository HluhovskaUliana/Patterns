namespace creational.factory;

public class GreenBeanSeed : ISeed
{
    public string Name => "Green Bean";
    public int GrowthTime => 3;
    
    public void Plant() => Console.WriteLine("Planting green bean...");
}