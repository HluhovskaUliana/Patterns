namespace structural.adapter
{
    public class ChickenAdapter : IFarmProduct
    {
        private Chicken _chicken;
    
        public ChickenAdapter(Chicken chicken)
        {
            _chicken = chicken;
        }
    
        public string GetProduct()
        {
            return _chicken.LayEgg();
        }
    }
}

