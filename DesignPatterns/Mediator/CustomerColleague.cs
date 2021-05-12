namespace DesignPatterns.Mediator
{
    using System;

    public class CustomerColleague : BaseColleague
    {
        public CustomerColleague(BaseMediator mediator) : base(mediator)
        {
        }

        public override void DoSomethingColleague(string message)
        {
            Console.WriteLine($"Customer get message: {message}");
        }
    }
}