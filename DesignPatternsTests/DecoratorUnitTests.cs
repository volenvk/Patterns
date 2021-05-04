using System;
using DesignPatterns.Decorator;
using NUnit.Framework;

namespace DesignPatternsTests
{
    public class DecoratorUnitTests
    {
        [Test]
        public void MallardDuckTest()
        {
            // Arrange
            var priceBigDarkRoast = 1.20 + 0.50;
            var bigDarkRoast = new DarkRoast(PortionSize.Big, new BeveragePortionSizeCost());

            var priceDarkRoastWithSoy = priceBigDarkRoast + 0.2 + 0.2;
            var darkRoastWithSoy = new Soy(bigDarkRoast, new CondimentPortionSizeCost());
            
            var priceDarkRoastWithMochaAndSoy = priceDarkRoastWithSoy + 0.5 + 0.2;
            var darkRoastWithMochaAndSoy = new Mocha(darkRoastWithSoy, new CondimentPortionSizeCost());

            // Act
            var cost = darkRoastWithMochaAndSoy.GetCost();
            
            // Assert
            Assert.AreEqual(priceBigDarkRoast, bigDarkRoast.GetCost());
            Assert.AreEqual(priceDarkRoastWithSoy, darkRoastWithSoy.GetCost());
            Assert.AreEqual(priceDarkRoastWithMochaAndSoy, cost);
            Assert.AreEqual(PortionSize.Big, darkRoastWithMochaAndSoy.Size);
            Console.WriteLine(darkRoastWithMochaAndSoy.Description);
            Console.WriteLine(cost);
        }
    }
}
