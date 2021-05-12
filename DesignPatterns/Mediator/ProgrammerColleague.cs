namespace DesignPatterns.Mediator
{
    using System;

    public class ProgrammerColleague : Colleague
    {
        public ProgrammerColleague(Mediator mediator) : base(mediator)
        {
        }

        public override void DoSomethingColleague(string message)
        {
            Console.WriteLine($"Programmer get message: {message}");
        }
    }
}