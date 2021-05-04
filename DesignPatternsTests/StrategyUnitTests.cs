using DesignPatterns.Strategy;
using NUnit.Framework;

namespace DesignPatternsTests
{
    public class StrategyUnitTests
    {
        [Test]
        public void MallardDuckTest()
        {
            // Arrange
            var mallard = new MallardDuck();
            mallard.SetFlyBehavior(new FlyWings());
            mallard.SetQuackBehavior(new Quack());

            // Act
            mallard.PerformFly();
            mallard.PerformQuack();
            
            // Assert
            Assert.Pass();
        }
    }
}