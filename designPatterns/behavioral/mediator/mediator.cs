namespace behavioral.mediator
{
    public interface IMediator
    {
        void Notify(object sender, string ev);
    }
    
    public class TownMediator : IMediator
    {
        private Farmer1 farmer;
        private Merchant merchant;
        private Blacksmith blacksmith;

        public TownMediator(Farmer1 farmer, Merchant merchant, Blacksmith blacksmith)
        {
            this.farmer = farmer;
            this.merchant = merchant;
            this.blacksmith = blacksmith;

            farmer.SetMediator(this);
            merchant.SetMediator(this);
            blacksmith.SetMediator(this);
        }

        public void Notify(object sender, string ev)
        {
            if (ev == "NeedSeeds")
            {
                Console.WriteLine("Farmer requests seeds → Merchant responds.");
                merchant.SellSeeds();
            }
            else if (ev == "NeedToolRepair")
            {
                Console.WriteLine("🔧 Farmer requests tool repair → Blacksmith responds.");
                blacksmith.RepairTool();
            }
        }
    }
    
    public abstract class TownMember
    {
        protected IMediator mediator;

        public void SetMediator(IMediator mediator)
        {
            this.mediator = mediator;
        }
    }

    public class Farmer1 : TownMember
    {
        public void AskForSeeds()
        {
            Console.WriteLine("Farmer: I need seeds!");
            mediator.Notify(this, "NeedSeeds");
        }

        public void AskForToolRepair()
        {
            Console.WriteLine("Farmer: My tool is broken!");
            mediator.Notify(this, "NeedToolRepair");
        }
    }

    public class Merchant : TownMember
    {
        public void SellSeeds()
        {
            Console.WriteLine("Merchant: Here are your seeds.");
        }
    }

    public class Blacksmith : TownMember
    {
        public void RepairTool()
        {
            Console.WriteLine("️Blacksmith: The tool has been repaired.");
        }
    }
}

