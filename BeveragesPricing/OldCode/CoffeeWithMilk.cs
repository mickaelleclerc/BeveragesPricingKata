namespace BeveragesPricing.OldCode
{
    public class CoffeeWithMilk : Coffee
    {
        public override double Price() 
        {
            return base.Price() +  0.10;
        }
    }
}
