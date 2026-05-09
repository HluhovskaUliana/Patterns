namespace structural.decorator;

public class StatsDecorator : ICharacterStats
{
    protected ICharacterStats stats;

    protected StatsDecorator(ICharacterStats stats)
    {
        this.stats = stats;
    }

    public virtual int GetHealth() => stats.GetHealth();
    public virtual int GetEnergy() => stats.GetEnergy();
    public virtual string GetDescription() => stats.GetDescription();
}