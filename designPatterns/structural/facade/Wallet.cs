namespace structural.facade;

public class Wallet
{
    public int Balance { get; private set; } = 0;

    public void AddMoney(int amount)
    {
        Balance += amount;
        Console.WriteLine($"Balance updated: {Balance} gold");
    }
}