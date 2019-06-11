namespace BeveragesPricing.NewCode
{
    public class HotChocolate : Beverage 
    {
        private const double UnitPrice = 1.45;
        
        public HotChocolate(params ISupplement[] supplements)
            : base(UnitPrice, supplements)
        {
        }
    }
}
