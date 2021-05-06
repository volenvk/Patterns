namespace DesignPatterns.State
{
    using System;

    public class GumballMachine
    {
        private int _count;
        private IState _state;

        public GumballMachine(int count)
        {
            _count = count;
            _state = new NoQuarterState(this);
        }
        
        public void SetState(IState state)
        {
            _state = state;
        }

        public bool HasBolls() => _count > 0;

        public void InsertQuarter()
        {
            _state.InsertQuarter();
        }

        public void EjectQuarter()
        {
            _state.EjectQuarter();
        }

        public void TurnCrank()
        {
            _state.TurnCrank();
            _state.Dispense();
        }

        public void ReleaseBall()
        {
            _count--;
            Console.WriteLine("Release ball!");
        }
    }
}