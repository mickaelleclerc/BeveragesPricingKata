namespace BeveragesPricing.NewCode
{
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Beverage : IBeverage
    {
        private readonly double price;
        private readonly IReadOnlyCollection<ISupplement> supplements;

        protected Beverage(double price, params ISupplement[] supplements)
        {
            this.price = price;
            this.supplements = supplements;
        }
        
        public double Price()
        {
            return this.price + this.GetTotalSupplementPrice();
        }

        private double GetTotalSupplementPrice()
        {
            return this.supplements.Sum(supplement => supplement.Price());
        }
    }
}