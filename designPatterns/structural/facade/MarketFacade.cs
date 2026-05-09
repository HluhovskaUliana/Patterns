namespace structural.facade;

public class MarketFacade
{
    private FacadeInventory inventory;
    private Pricing pricing;
    private Wallet wallet;

    public MarketFacade(FacadeInventory inventory, Pricing pricing, Wallet wallet)
    {
        this.inventory = inventory;
        this.pricing = pricing;
        this.wallet = wallet;
    }

    public void SellAllProducts()
    {
        var items = inventory.GetItems();
        int total = 0;

        foreach (var item in items)
        {
            int price = pricing.GetPrice(item);
            Console.WriteLine($"Sold {item} for {price} gold");
            total += price;
        }

        wallet.AddMoney(total);
        inventory.Clear();
    }
}