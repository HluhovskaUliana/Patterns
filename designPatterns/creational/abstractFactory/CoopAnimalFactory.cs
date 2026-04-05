namespace creational.abstractFactory;
using creational.abstractFactory.Animals;

public class CoopAnimalFactory : AnimalFactory
{
    public override IAnimal GetAnimal(AnimalType type) => type switch
    {
        AnimalType.Chicken => new Chicken(),
        AnimalType.Duck => new Duck(),
        AnimalType.Rabbit => new Rabbit(),
        _ => throw new ArgumentException($"Not a coop animal: {type}")
    };
}