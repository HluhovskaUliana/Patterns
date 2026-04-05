using creational.abstractFactory.Animals;

namespace creational.abstractFactory;

public class HabitatAnimalFactory
{
    public AnimalFactory GetAnimalFactory(HabitatType type) => type switch
    {
        HabitatType.Barn => new BarnAnimalFactory(),
        HabitatType.Coop => new CoopAnimalFactory(),
        _ => throw new ArgumentException($"Unknown habitat: {type}")
    };
}