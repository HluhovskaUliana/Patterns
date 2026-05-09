using structural.bridge.Materials;

namespace structural.bridge.Tools
{
   public class Axe : Tool
   {
       public Axe(IMaterial material) : base(material) { }
   
       public override void Use()
       {
           Console.WriteLine("Axe of material:: " + material.GetMaterial());
       }
   } 
}
