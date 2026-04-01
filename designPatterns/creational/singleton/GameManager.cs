namespace creational.singleton;

public class InventoryManager
{
    private static InventoryManager instance = null;

    private InventoryManager() { }

    public static InventoryManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new InventoryManager();
            }
            return instance;
        }
    }
}
