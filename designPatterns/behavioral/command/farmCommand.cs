using System;

namespace behavioral.command
{
    public interface ICommand
    {
        void Execute();
    }

    // Конкретні команди
    public class WaterPlantsCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("The plants are watered!");
        }
    }

    public class HarvestCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("The harvest is harvested!");
        }
    }

    public class FeedAnimalsCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Animals are fed!");
        }
    }

    // Invoker (той, хто виконує команди)
    public class Farmer
    {
        private ICommand command;

        public void SetCommand(ICommand cmd)
        {
            command = cmd;
        }

        public void ExecuteCommand()
        {
            command?.Execute();
        }
    }
}
