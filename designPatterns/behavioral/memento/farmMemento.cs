namespace behavioral.memento
{
    public class FarmMemento
    {
        public string State { get; }

        public FarmMemento(string state)
        {
            State = state;
        }
    }

    // Originator: ферма
    public class Farm
    {
        public string State { get; private set; }

        public void SetState(string state)
        {
            State = state;
            Console.WriteLine($"Farm state changed to: {state}");
        }

        public FarmMemento SaveState()
        {
            Console.WriteLine("Saving farm state...");
            return new FarmMemento(State);
        }

        public void RestoreState(FarmMemento memento)
        {
            State = memento.State;
            Console.WriteLine($"Restored farm state to: {State}");
        }
    }

    // Caretaker: керує історією станів
    public class FarmCaretaker
    {
        private Stack<FarmMemento> history = new Stack<FarmMemento>();

        public void Save(Farm farm)
        {
            history.Push(farm.SaveState());
        }

        public void Undo(Farm farm)
        {
            if (history.Count > 0)
            {
                var memento = history.Pop();
                farm.RestoreState(memento);
            }
        }
    }
}

