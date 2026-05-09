namespace structural.bridge.Tools;
using structural.bridge.Materials;

public class Pickaxe : Tool
{
    public Pickaxe(IMaterial material) : base(material) { }

    public override void Use()
    {
        Console.WriteLine("Pickaxe of material: " + material.GetMaterial());
    }
}