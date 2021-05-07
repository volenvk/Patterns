namespace DesignPatterns.State
{
    public class WinnerState : IState
    {
        private readonly GumballMachine _machine;

        public WinnerState(GumballMachine machine)
        {
            _machine = machine;
        }
        
        public void InsertQuarter()
        {
            
        }

        public void EjectQuarter()
        {
            
        }

        public void TurnCrank()
        {
            
        }

        public void Dispense()
        {
            _machine.ReleaseBall();
            
            if (_machine.HasBolls())
            {
                _machine.ReleaseBall();
            }

            if (_machine.HasBolls())
            {
                _machine.SetState(new NoQuarterState(_machine));
                return;
            }
            
            _machine.SetState(new SoldOutState(_machine));
        }

        public override string ToString()
		{
			return "Winner state.";		
        }
    }
}