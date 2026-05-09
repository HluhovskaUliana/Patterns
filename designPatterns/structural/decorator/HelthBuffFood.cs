namespace structural.decorator;

public class HealthBuffFood : StatsDecorator
{
    private int bonus;

    public HealthBuffFood(ICharacterStats stats, int bonus) : base(stats)
    {
        this.bonus = bonus;
    }

    public override int GetHealth() => stats.GetHealth() + bonus;
    public override string GetDescription() => stats.GetDescription() + $" + health buff (+{bonus})"; 
}