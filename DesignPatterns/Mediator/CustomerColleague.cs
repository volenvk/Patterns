namespace DesignPatterns.Mediator
{
    using System;

    public class CustomerColleague : Colleague
    {
        public CustomerColleague(Mediator mediator) : base(mediator)
        {
        }

        public override void DoSomethingColleague(string message)
        {
            Console.WriteLine($"Customer get message: {message}");
        }
    }
}