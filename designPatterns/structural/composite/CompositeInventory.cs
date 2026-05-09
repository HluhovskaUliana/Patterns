namespace structural.composite;

public class CompositeInventory : IItem
{
    private List<IItem> slots = new List<IItem>();
    
    public void AddSlot(IItem item)
    {
        slots.Add(item);
    }

    public void ShowInfo()
    {
        Console.WriteLine("=== Inventory ===");
        foreach (var slot in slots)
        {
            slot.ShowInfo();
        }
    }
}