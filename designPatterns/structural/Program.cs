using System;
using structural.adapter;
using structural.bridge.Materials;
using structural.bridge.Tools;


class Program 
{
    static void Main()
    {
        Console.WriteLine("---------- Adapter pattern ---------");
        Inventory inventory = new Inventory();
        
        Chicken chicken = new Chicken();
        Cow cow = new Cow();
        
        //отримання продукту через адаптер (IFarmProduct)
        inventory.AddProduct(new ChickenAdapter(chicken));
        inventory.AddProduct(new CowAdapter(cow));

        inventory.ShowInventory();
        
        Console.WriteLine("---------- Bridge pattern ---------");
        Tool woodenAxe = new Axe(new Wood());
        Tool ironPickaxe = new Pickaxe(new Iron());
        Tool ironAxe = new Axe(new Iron());

        woodenAxe.Use();   //сокира з дерева
        ironAxe.Use(); //сокира з заліза
        ironPickaxe.Use(); //кирка з заліза
        
        Console.WriteLine("---------- Composite pattern ---------");
        
    }
}
