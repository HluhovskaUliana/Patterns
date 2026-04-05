namespace creational.abstractFactory.Animals;

public class Duck : IAnimal
{
    public string Name => "Duck";
    public string MakeSound() =>  "Quack-quack!";
}