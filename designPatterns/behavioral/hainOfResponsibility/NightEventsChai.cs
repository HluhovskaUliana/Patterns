namespace behavioral.hainOfResponsibility
{
    public class NightContext
    {
        public bool HasBats { get; set; }
        public bool HasMeteor { get; set; }
        public bool HasFestival { get; set; }
        public bool HasWitch { get; set; }
    }
    
    public abstract class NightEventHandler
    {
        protected NightEventHandler next;
    
        public void SetNext(NightEventHandler handler)
        {
            next = handler;
        }
    
        public abstract void Handle(NightContext context);
    }
    
    public class BatEventHandler : NightEventHandler
    {
        public override void Handle(NightContext context)
        {
            if (context.HasBats)
                Console.WriteLine("Bats attack in the mine!");
            else
                next?.Handle(context);
        }
    }
    
    public class MeteorEventHandler : NightEventHandler
    {
        public override void Handle(NightContext context)
        {
            if (context.HasMeteor)
                Console.WriteLine("A meteorite fell on a farm!");
            else
                next?.Handle(context);
        }
    }
    
    public class FestivalEventHandler : NightEventHandler
    {
        public override void Handle(NightContext context)
        {
            if (context.HasFestival)
                Console.WriteLine("There is a night festival!");
            else
                next?.Handle(context);
        }
    }
    
    public class WitchEventHandler : NightEventHandler
    {
        public override void Handle(NightContext context)
        {
            if (context.HasWitch)
                Console.WriteLine("The witch charmed the chicken coop!");
            else
                next?.Handle(context);
        }
    }
    
    public class DefaultEventHandler : NightEventHandler
    {
        public override void Handle(NightContext context)
        {
            Console.WriteLine("The night passed peacefully.");
        }
    }
}


