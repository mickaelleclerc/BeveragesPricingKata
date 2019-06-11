namespace BeveragesPricing.Tests
{
    using BeveragesPricing.NewCode;
    using FluentAssertions;
    using NUnit.Framework;

    public class BeveragesPricingTest 
    {
        [Test]
        public void Computes_Coffee_Price()
        {
            IBeverage coffee = new Coffee();
            
            coffee.Price().Should().BeApproximately(1.2, 0.001);
        }

        [Test]
        public void Computes_Tea_Price() 
        {
            IBeverage tea = new Tea();

            tea.Price().Should().BeApproximately(1.5, 0.001);
        }

        [Test]
        public void Computes_Hot_Chocolate_Price() 
        {
            IBeverage hotChocolate = new HotChocolate();
            
            hotChocolate.Price().Should().BeApproximately(1.45, 0.001);
        }

        [Test]
        public void Computes_Tea_With_Milk_Price()
        {
            IBeverage teaWithMilk = new Tea(new MilkSupplement());
            
            teaWithMilk.Price().Should().BeApproximately(1.6, 0.001);
        }

        [Test]
        public void Computes_Coffee_With_Milk_Price() 
        {
            IBeverage coffeeWithMilk = new Coffee(new MilkSupplement());
            
            coffeeWithMilk.Price().Should().BeApproximately(1.3, 0.001);
        }

        [Test]
        public void Computes_Coffee_With_Milk_And_Cream_Price()
        {
            IBeverage coffeeWithMilkAndCream = new Coffee(
                new MilkSupplement(),
                new CreamSupplement());
            
            coffeeWithMilkAndCream.Price().Should().BeApproximately(1.45, 0.001);
        }

        [Test]
        public void Computes_Coffee_With_Double_Cream_Price()
        {
            IBeverage coffeeWithDoubleCream = new Coffee(new DoubleCreamSupplement());
            
            coffeeWithDoubleCream.Price().Should().BeApproximately(1.4, 0.001);
        }

        [Test]
        public void Computes_Hot_Chocolate_With_Cream_Price() 
        {
            IBeverage hotChocolateWithCream = new HotChocolate(new CreamSupplement());
            
            hotChocolateWithCream.Price().Should().BeApproximately(1.6, 0.001);
        }
    }
}
