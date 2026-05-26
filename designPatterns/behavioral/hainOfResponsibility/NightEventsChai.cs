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
                Console.WriteLine("Кажани атакують у шахті!");
            else
                next?.Handle(context);
        }
    }
    
    public class MeteorEventHandler : NightEventHandler
    {
        public override void Handle(NightContext context)
        {
            if (context.HasMeteor)
                Console.WriteLine("Метеорит впав на фермі!");
            else
                next?.Handle(context);
        }
    }
    
    public class FestivalEventHandler : NightEventHandler
    {
        public override void Handle(NightContext context)
        {
            if (context.HasFestival)
                Console.WriteLine("Відбувається нічний фестиваль!");
            else
                next?.Handle(context);
        }
    }
    
    public class WitchEventHandler : NightEventHandler
    {
        public override void Handle(NightContext context)
        {
            if (context.HasWitch)
                Console.WriteLine("Відьма зачарувала курник!");
            else
                next?.Handle(context);
        }
    }
    
    public class DefaultEventHandler : NightEventHandler
    {
        public override void Handle(NightContext context)
        {
            Console.WriteLine("Ніч минула спокійно.");
        }
    }
}


