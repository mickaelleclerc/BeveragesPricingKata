namespace BeveragesPricing.OldCode
{
    public class Tea : IBeverage
    {
        public virtual double Price()
        {
            return 1.5;
        }
    }
}