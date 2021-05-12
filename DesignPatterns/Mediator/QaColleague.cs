namespace DesignPatterns.Mediator
{
    using System;

    public class QaColleague : BaseColleague
    {
        public QaColleague(BaseMediator mediator) : base(mediator)
        {
        }

        public override void DoSomethingColleague(string message)
        {
            Console.WriteLine($"QA get message: {message}");
        }
    }
}