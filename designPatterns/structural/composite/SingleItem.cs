namespace structural.composite;

public class SingleItem : IItem
{
    private string name;
    
    public SingleItem(string name)
    {
        this.name = name;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Name: {name}");
    }
}