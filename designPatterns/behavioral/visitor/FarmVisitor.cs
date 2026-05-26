namespace behavioral.visitor
{
    public interface IFarmElement
    {
        void Accept(IVisitor visitor);
    }

    // Конкретні елементи
    public class Cow : IFarmElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitCow(this);
        }
    }

    public class Crop : IFarmElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitCrop(this);
        }
    }

    // Інтерфейс відвідувача
    public interface IVisitor
    {
        void VisitCow(Cow cow);
        void VisitCrop(Crop crop);
    }

    // Конкретний відвідувач: фермер
    public class FarmerVisitor : IVisitor
    {
        public void VisitCow(Cow cow)
        {
            Console.WriteLine("Farmer feeds the cow.");
        }

        public void VisitCrop(Crop crop)
        {
            Console.WriteLine("Farmer waters the crop.");
        }
    }

    // Конкретний відвідувач: торговець
    public class TraderVisitor : IVisitor
    {
        public void VisitCow(Cow cow)
        {
            Console.WriteLine("Trader evaluates cow: worth 1500g.");
        }

        public void VisitCrop(Crop crop)
        {
            Console.WriteLine("Trader evaluates crop: worth 200g.");
        }
    }
}