namespace DesignPatterns.Mediator
{
    public abstract class Colleague
    {
        private readonly Mediator _mediator;
 
        protected Colleague(Mediator mediator)
        {
            _mediator = mediator;
        }
 
        public void SendToNextColleague(string message)
        {
            _mediator.Send(this, message);
        }
        
        public abstract void DoSomethingColleague(string message);
    }
}