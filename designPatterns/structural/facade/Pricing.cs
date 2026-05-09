namespace structural.facade;

public class Pricing
{
    public int GetPrice(string item)
    {
        return item switch
        {
            "honey" => 50,
            "catfish" => 70,
            "potato" => 60,
            _ => 10
        };
    }
}