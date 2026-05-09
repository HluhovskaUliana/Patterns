using System;
using System.Collections.Generic;

namespace structural.adapter
{
   public class Inventory
   {
       private List<IFarmProduct> _products = new List<IFarmProduct>();
   
       public void AddProduct(IFarmProduct product)
       {
           _products.Add(product);
       }
   
       public void ShowInventory()
       {
           foreach (var product in _products)
           {
               Console.WriteLine("Received: " + product.GetProduct());
           }
       }
   } 
}

