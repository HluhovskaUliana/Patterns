using structural.bridge.Materials;

namespace structural.bridge.Tools
{
   public abstract class Tool
   {
       protected IMaterial material;

       protected Tool(IMaterial material)
       {
           this.material = material;
       }
       
       public abstract void Use();
   } 
}

