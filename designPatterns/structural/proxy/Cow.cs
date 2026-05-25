namespace structural.proxy;
using System;

public class Cow1 : IAnimal
{
    public void GiveProduct()
    {
        Console.WriteLine("The cow gives milk");
    }
}