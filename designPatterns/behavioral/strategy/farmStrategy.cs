namespace behavioral.strategy
{
    // інтерфейс стратегій
    public interface IHarvestStrategy
    {
        void Harvest(string crop);
    }

    // конкретні стратегії
    public class ManualHarvestStrategy : IHarvestStrategy
    {
        public void Harvest(string crop)
        {
            Console.WriteLine($"Manually harvested {crop}.");
        }
    }

    public class MachineHarvestStrategy : IHarvestStrategy
    {
        public void Harvest(string crop)
        {
            Console.WriteLine($"Machine harvested {crop}.");
        }
    }

    public class MagicalHarvestStrategy : IHarvestStrategy
    {
        public void Harvest(string crop)
        {
            Console.WriteLine($"Magically harvested {crop}!");
        }
    }

    // контекст
    public class Farmer2
    {
        private IHarvestStrategy strategy;

        public Farmer2(IHarvestStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void SetStrategy(IHarvestStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void HarvestCrop(string crop)
        {
            strategy.Harvest(crop);
        }
    }
}