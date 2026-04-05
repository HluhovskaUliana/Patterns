namespace creational.abstractFactory.Animals;

public class Pig : IAnimal
{
    public string Name => "Pig";
    public string MakeSound() =>  "Oink-oink!";
}