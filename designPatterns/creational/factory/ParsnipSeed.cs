namespace creational.factory;

public class ParsnipSeed : ISeed
{
    public string Name => "Parsnip";
    public int GrowthTime => 4;
    
    public void Plant() => Console.WriteLine("Planting parsnip...");
}