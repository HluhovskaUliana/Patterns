namespace creational.abstractFactory.Animals;

public class Cow : IAnimal
{
    public string Name => "Cow";
    public string MakeSound() => "Moo!";
}