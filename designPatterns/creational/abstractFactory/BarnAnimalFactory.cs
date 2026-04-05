using System.Runtime.CompilerServices;
using creational.abstractFactory.Animals;

namespace creational.abstractFactory;

public class BarnAnimalFactory : AnimalFactory
{
    public override IAnimal GetAnimal(AnimalType type) => type switch
    {
         AnimalType.Cow => new Cow(),
         AnimalType.Goat => new Goat(),
         AnimalType.Pig => new Pig(),
         _ => throw new ArgumentException($"Not a barn animal: {type}")
    };
}