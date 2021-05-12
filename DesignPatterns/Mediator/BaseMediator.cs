namespace DesignPatterns.Mediator
{
    public abstract class BaseMediator
    {
        public abstract void Send(BaseColleague baseColleague, string msg);
    }
}