namespace DesignPatterns.State
{
    using System;

    public class NoQuarterState : IState
    {
        private readonly GumballMachine _machine;

        public NoQuarterState(GumballMachine machine)
        {
            _machine = machine;
        }
        
        public void InsertQuarter()
        {
            if (_machine.HasBolls())
            {
                _machine.SetState(new HasQuarterState(_machine));
                return;
            }
            
            _machine.SetState(new SoldOutState(_machine));
        }

        public void EjectQuarter()
        {
            throw new InvalidOperationException("You haven't inserted a quarter.");
        }

        public void TurnCrank()
        {
            throw new InvalidOperationException("You turned, but there's no quarter.");
        }

        public void Dispense()
        {
            throw new InvalidOperationException("You need to pay.");
        }
    }
}