namespace creational.abstractFactory.Animals;

public class Rabbit : IAnimal
{
    public string Name => "Rabbit";
    public string MakeSound() => "Squeak!";
}