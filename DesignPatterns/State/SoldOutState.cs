namespace DesignPatterns.State
{
    using System;

    public class SoldOutState : IState
    {
        private readonly GumballMachine _machine;

        public SoldOutState(GumballMachine machine)
        {
            _machine = machine;
        }

        public void InsertQuarter()
        {
            throw new InvalidOperationException("No gumballs.");
        }

        public void EjectQuarter()
        {
            _machine.SetState(new SoldOutState(_machine));
        }

        public void TurnCrank()
        {
            _machine.SetState(new SoldOutState(_machine));
        }

        public void Dispense()
        {
            throw new InvalidOperationException("No gumballs.");
        }
    }
}