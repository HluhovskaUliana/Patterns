namespace structural.decorator;

public class BaseStats : ICharacterStats
{
    public int GetHealth() => 100;
    public int GetEnergy() => 100;
    public string GetDescription() => "Base stats";
}