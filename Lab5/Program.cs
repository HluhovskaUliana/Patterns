using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab6Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Strategy через делегати 
            Func<int, int, int> add = (a, b) => a + b;
            Func<int, int, int> multiply = (a, b) => a * b;

            Console.WriteLine("Strategy Add: " + ExecuteStrategy(add, 3, 4));
            Console.WriteLine("Strategy Multiply: " + ExecuteStrategy(multiply, 3, 4));

            // Factory Method через лямбди 
            Func<string, IAnimal> factory = type =>
                type switch
                {
                    "cow" => new Cow(),
                    "chicken" => new Chicken(),
                    _ => throw new ArgumentException("Unknown type")
                };

            IAnimal animal1 = factory("cow");
            IAnimal animal2 = factory("chicken");
            animal1.Speak();
            animal2.Speak();

            // Decorator через функції 
            Func<string, string> baseDrink = d => d;
            Func<string, string> addMilk = d => d + " + milk";
            Func<string, string> addHoney = d => d + " + honey";

            var decorated = addHoney(addMilk(baseDrink("Tea")));
            Console.WriteLine("Decorator: " + decorated);

            // Execute Around 
            ExecuteAround(() =>
            {
                Console.WriteLine("Doing important work inside...");
            });
        }

        // Strategy
        static int ExecuteStrategy(Func<int, int, int> strategy, int a, int b) =>
            strategy(a, b);

        // Factory Method
        interface IAnimal { void Speak(); }
        class Cow : IAnimal { public void Speak() => Console.WriteLine("Moo!"); }
        class Chicken : IAnimal { public void Speak() => Console.WriteLine("Cluck!"); }

        // Execute Around
        static void ExecuteAround(Action action)
        {
            Console.WriteLine(">>> Before work");
            action();
            Console.WriteLine(">>> After work");
        }
    }
}
