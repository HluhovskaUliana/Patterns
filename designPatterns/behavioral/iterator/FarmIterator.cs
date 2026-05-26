namespace behavioral.iterator
{
    public interface IIterator<T>
    {
        bool HasNext();
        T Next();
    }

    // Інтерфейс колекції
    public interface IAggregate<T>
    {
        IIterator<T> CreateIterator();
    }

    // Конкретна колекція 
    public class HarvestCollection : IAggregate<string>
    {
        private List<string> items = new List<string>();

        public void AddItem(string item)
        {
            items.Add(item);
        }

        public IIterator<string> CreateIterator()
        {
            return new HarvestIterator(items);
        }
    }

    // Конкретний ітератор
    public class HarvestIterator : IIterator<string>
    {
        private List<string> items;
        private int position = 0;

        public HarvestIterator(List<string> items)
        {
            this.items = items;
        }

        public bool HasNext()
        {
            return position < items.Count;
        }

        public string Next()
        {
            return items[position++];
        }
    }
}

