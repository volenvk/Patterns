namespace DesignPatternsTests
{
    using DesignPatterns.Mediator;
    using NUnit.Framework;

    public class MediatorTests
    {
        [Test]
        public void ManagerMediatorTest()
        {
            // Arrange
            var mediator = new ManagerMediator();
            // Act
            mediator.Customer.SendToNextColleague("Есть заказ, надо сделать программу");
            mediator.Programmer.SendToNextColleague("Программа готова, надо протестировать");
            mediator.QA.SendToNextColleague("Программа протестирована и готова к продаже");
            // Assert
            Assert.Pass();
        }
    }
}