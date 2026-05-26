namespace behavioral.state
{
    public interface IFarmState
    {
        void Handle(Farm2 farm);
    }

    // стани
    public class PlantingState : IFarmState
    {
        public void Handle(Farm2 farm)
        {
            Console.WriteLine("The farm is in planting state.");
            farm.SetState(new GrowingState());
        }
    }

    public class GrowingState : IFarmState
    {
        public void Handle(Farm2 farm)
        {
            Console.WriteLine("The crops are growing.");
            farm.SetState(new HarvestingState());
        }
    }

    public class HarvestingState : IFarmState
    {
        public void Handle(Farm2 farm)
        {
            Console.WriteLine("The crops are ready to harvest!");
            farm.SetState(new PlantingState()); // коло починається знову
        }
    }
    
    public class Farm2
    {
        private IFarmState state;

        public Farm2(IFarmState initialState)
        {
            state = initialState;
        }

        public void SetState(IFarmState newState)
        {
            state = newState;
        }

        public void Request()
        {
            state.Handle(this);
        }
    }
}