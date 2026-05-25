namespace structural.proxy;
using System;

public class Chicken1 : IAnimal
{
    public void GiveProduct()
    {
        Console.WriteLine("The chicken laid an egg");
    }
}
