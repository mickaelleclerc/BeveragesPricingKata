namespace BeveragesPricing.Tests
{
    using BeveragesPricing.NewCode;
    using FluentAssertions;
    using NUnit.Framework;

    public class SupplementTest
    {
        [Test]
        public void Milk_Supplement_Price()
        {
            MilkSupplement milkSupplement = new MilkSupplement();
            
            milkSupplement.Price().Should().BeApproximately(0.10, 0.001);
        }
        
        [Test]
        public void Cream_Supplement_Price()
        {
            CreamSupplement creamSupplement = new CreamSupplement();
            
            creamSupplement.Price().Should().BeApproximately(0.15, 0.001);
        }
        
        [Test]
        public void Double_Cream_Supplement_Price()
        {
            DoubleCreamSupplement doubleCreamSupplement = new DoubleCreamSupplement();
            
            doubleCreamSupplement.Price().Should().BeApproximately(0.2, 0.001);
        }
    }
}