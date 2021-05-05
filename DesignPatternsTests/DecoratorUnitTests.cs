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
            var priceBigDarkRoast = 1.20 + 0.50 + (double)(1.2 * 15)/100;
            var bigDarkRoast = new DarkRoast();

            var priceDarkRoastWithSoy = priceBigDarkRoast + 0.2 + 0.2 + (double)(0.2 * 5)/100;
            var darkRoastWithSoy = new Soy(bigDarkRoast);
            
            var priceDarkRoastWithMochaAndSoy = priceDarkRoastWithSoy + 0.5 + 0.2 + (double)(0.5 * 5)/100;
            var darkRoastWithMochaAndSoy = new Mocha(darkRoastWithSoy);

            // Act
            var cost = darkRoastWithMochaAndSoy.GetCost(PortionSize.Big);
            
            // Assert
            Assert.AreEqual(priceBigDarkRoast, bigDarkRoast.GetCost(PortionSize.Big));
            Assert.AreEqual(priceDarkRoastWithSoy, darkRoastWithSoy.GetCost(PortionSize.Big));
            Assert.AreEqual(priceDarkRoastWithMochaAndSoy, cost);
            Console.WriteLine(darkRoastWithMochaAndSoy.Description);
            Console.WriteLine(cost);
        }
    }
}
