namespace BeveragesPricing.NewCode
{
    public class Tea : Beverage 
    {
        private const double UnitPrice = 1.5;
        
        public Tea(params ISupplement[] supplements)
            : base(UnitPrice, supplements)
        {
        }
    }
}
