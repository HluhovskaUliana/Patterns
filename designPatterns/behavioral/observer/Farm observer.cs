namespace behavioral.observer
{
    public interface IObserver
    {
        void Update(string farmEvent);
    }

    
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify(string farmEvent);
    }
    
    public class Farm1 : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify(string farmEvent)
        {
            Console.WriteLine($"Farm event: {farmEvent}");
            foreach (var observer in observers)
            {
                observer.Update(farmEvent);
            }
        }

        // Example farm actions
        public void Harvest()
        {
            Notify("Harvested crops");
        }

        public void WaterPlants()
        {
            Notify("Watered plants");
        }
    }

    // Concrete Observers
    public class Villager : IObserver
    {
        private string name;

        public Villager(string name)
        {
            this.name = name;
        }

        public void Update(string farmEvent)
        {
            Console.WriteLine($"{name} noticed: {farmEvent}");
        }
    }
}

