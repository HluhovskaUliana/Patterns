namespace structural.proxy;

public class AnimalProxy : IAnimal
{
    private IAnimal realAnimal;
    private bool isFed;
    private bool isHappy;

    public AnimalProxy(IAnimal animal, bool fed, bool happy)
    {
        realAnimal = animal;
        isFed = fed;
        isHappy = happy;
    }

    public void GiveProduct()
    {
        if (!isFed)
        {
            Console.WriteLine("The animal is hungry, there is no product!");
            return;
        }

        if (!isHappy)
        {
            Console.WriteLine("The animal is sad, there is no product!");
            return;
        }

        realAnimal.GiveProduct();
    }
}