namespace behavioral.templateMethod
{
    // Абстрактний клас, який задає шаблон алгоритму
    public abstract class FarmActivity
    {
        // визначає послідовність кроків
        public void PerformActivity()
        {
            PrepareTools();   
            DoMainWork();     //реалізується у підкласах 
            FinishWork();     
        }

        // Загальний метод для всіх активностей
        protected void PrepareTools()
        {
            Console.WriteLine("🔧 Preparing tools...");
        }

        // Абстрактний метод – реалізується у підкласах
        protected abstract void DoMainWork();

        // Загальний метод для всіх активностей
        protected void FinishWork()
        {
            Console.WriteLine("Work finished.\n");
        }
    }

    // посадка рослин
    public class PlantingActivity : FarmActivity
    {
        protected override void DoMainWork()
        {
            Console.WriteLine("Planting seeds in the field.");
        }
    }

    // полив рослин
    public class WateringActivity : FarmActivity
    {
        protected override void DoMainWork()
        {
            Console.WriteLine("Watering the crops.");
        }
    }

    // збір урожаю
    public class HarvestingActivity : FarmActivity
    {
        protected override void DoMainWork()
        {
            Console.WriteLine("Harvesting ripe crops.");
        }
    }
}