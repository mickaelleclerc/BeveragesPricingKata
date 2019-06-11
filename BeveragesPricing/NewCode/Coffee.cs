namespace BeveragesPricing.NewCode
{
    public class Coffee : Beverage
    {
        private const double UnitPrice = 1.2;
        
        public Coffee(params ISupplement[] supplements) 
            : base(UnitPrice, supplements)
        {
        }
    }
}