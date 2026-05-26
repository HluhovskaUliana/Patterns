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
            Console.WriteLine("Рослини политі!");
        }
    }

    public class HarvestCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Урожай зібрано!");
        }
    }

    public class FeedAnimalsCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Тварини нагодовані!");
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
