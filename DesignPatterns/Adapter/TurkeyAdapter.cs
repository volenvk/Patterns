namespace DesignPatterns.Adapter
{
    using Strategy;

    public class TurkeyAdapter : ITurkey
    {
        private readonly Duck _duck;

        public TurkeyAdapter(Duck duck)
        {
            _duck = duck;
        }

        public void Gobble()
        {
            _duck.PerformQuack();
        }

        public void Display()
        {
            _duck.Display();
        }
    }
}