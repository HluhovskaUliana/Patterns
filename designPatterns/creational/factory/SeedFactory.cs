namespace creational.factory;

public class SeedFactory
{
    public ISeed Create(SeedType type) => type switch
    {
        SeedType.Cauliflower => new CauliflowerSeed(),
        SeedType.GreenBean => new GreenBeanSeed(),
        SeedType.Parsnip => new ParsnipSeed(),
        _ => throw new ArgumentOutOfRangeException(nameof(type), $"Unknown seed type: {type}")
    };
}