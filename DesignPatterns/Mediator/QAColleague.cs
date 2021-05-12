namespace DesignPatterns.Mediator
{
    using System;

    public class QAColleague : Colleague
    {
        public QAColleague(Mediator mediator) : base(mediator)
        {
        }

        public override void DoSomethingColleague(string message)
        {
            Console.WriteLine($"QA get message: {message}");
        }
    }
}