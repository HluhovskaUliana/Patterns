namespace structural.facade;

public class FacadeInventory
{
    private List<string> items = new List<string>();

    public void AddItem(string item) => items.Add(item);

    public List<string> GetItems() => items;

    public void Clear() => items.Clear();
}