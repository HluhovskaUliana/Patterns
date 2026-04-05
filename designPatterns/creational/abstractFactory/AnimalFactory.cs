namespace creational.abstractFactory;

public abstract class AnimalFactory
{
    public abstract IAnimal GetAnimal(AnimalType type);
}