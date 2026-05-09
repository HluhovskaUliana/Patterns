namespace structural.composite;

public class ItemGroup : IItem
{
    private string groupName;
    private List<IItem> items = new List<IItem>();

    public ItemGroup(string groupName)
    {
        this.groupName = groupName;
    }

    public void AddItem(IItem item)
    {
        items.Add(item);
    }

    public void RemoveItem(IItem item)
    {
        items.Remove(item);
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Group of objects: {groupName}");
        foreach (var item in items)
        {
            item.ShowInfo();
        }
    }
}