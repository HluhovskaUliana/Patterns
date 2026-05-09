namespace structural.decorator;

public class EnergyBuffFood : StatsDecorator
{
    private int bonus;

    public EnergyBuffFood(ICharacterStats stats, int bonus) : base(stats)
    {
        this.bonus = bonus;
    }

    public override int GetEnergy() => stats.GetEnergy() + bonus;
    public override string GetDescription() => stats.GetDescription() + $" + energy buff (+{bonus})";
}