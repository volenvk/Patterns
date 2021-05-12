namespace DesignPatterns.Mediator
{
    public abstract class Mediator
    {
        public abstract void Send(Colleague colleague, string msg);
    }
}