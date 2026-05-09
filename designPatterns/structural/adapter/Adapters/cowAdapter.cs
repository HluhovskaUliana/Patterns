namespace structural.adapter
{
    public class CowAdapter : IFarmProduct
    {
        private Cow _cow;
        
        public CowAdapter(Cow cow) 
        { 
            _cow = cow; 
        }
        public string GetProduct() 
        { 
            return _cow.GiveMilk();
        }
    }
}




