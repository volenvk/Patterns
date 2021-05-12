namespace DesignPatternsTests
{
    using DesignPatterns.Bridge;
    using NUnit.Framework;

    public class BridgeTests
    {
        [Test]
        public void GooglePixelTest()
        {
            // Arrange
            var gadget = new GooglePixel();
            gadget.SetAdapter(new GooglePixelAdapter());
            // Act
            gadget.OnCharge();

            // Assert
            gadget.ShowCharge();
            
            gadget.SetAdapter(new SamsungAdapter());
            // Act
            gadget.OnCharge();
            
            Assert.Pass();
        }
    }
}