namespace DesignPatterns.Mediator
{
    public abstract class BaseColleague
    {
        private readonly BaseMediator _mediator;
 
        protected BaseColleague(BaseMediator mediator)
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