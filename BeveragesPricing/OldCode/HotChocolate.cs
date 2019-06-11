namespace BeveragesPricing.OldCode
{
    public class HotChocolate : IBeverage 
    {
        public virtual double Price()
        {
            return 1.45;
        }
    }
}
