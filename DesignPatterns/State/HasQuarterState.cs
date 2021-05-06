namespace DesignPatterns.State
{
    using System;

    public class HasQuarterState : IState
    {
        private readonly GumballMachine _machine;

        private readonly Random _random;

        public HasQuarterState(GumballMachine machine)
        {
            _machine = machine;
            _random = new Random(DateTime.Now.Millisecond);
        }
        
        public void InsertQuarter()
        {
            throw new InvalidOperationException("You can't insert another quarter.");
        }

        public void EjectQuarter()
        {
            _machine.SetState(new NoQuarterState(_machine));
        }

        public void TurnCrank()
        {
            var winner = _random.Next(10);
            if (winner == 0)
                _machine.SetState(new WinnerState(_machine));
            else
                _machine.SetState(new SoldState(_machine));
        }

        public void Dispense()
        {
            throw new InvalidOperationException("No gumball dispensed.");
        }
    }
}