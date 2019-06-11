namespace BeveragesPricing.OldCode
{
    public class TeaWithMilk : Tea 
    {
        public override double Price() 
        {
            return base.Price() +  0.10;
        }
    }
}
