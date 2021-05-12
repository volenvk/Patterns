namespace DesignPatterns.Mediator
{
    using System;

    public class ProgrammerColleague : BaseColleague
    {
        public ProgrammerColleague(BaseMediator mediator) : base(mediator)
        {
        }

        public override void DoSomethingColleague(string message)
        {
            Console.WriteLine($"Programmer get message: {message}");
        }
    }
}