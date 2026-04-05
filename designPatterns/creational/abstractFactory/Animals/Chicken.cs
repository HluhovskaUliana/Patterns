namespace creational.abstractFactory.Animals;

public class Chicken : IAnimal
{
    public string Name => "Chicken";
    public string MakeSound() =>  "Cluck-cluck!";
}