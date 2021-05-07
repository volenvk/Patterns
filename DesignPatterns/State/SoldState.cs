namespace DesignPatterns.State
{
    using System;

    public class SoldState : IState
    {
        private readonly GumballMachine _machine;

        public SoldState(GumballMachine machine)
        {
            _machine = machine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait.");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You already turned the crank.");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Please wait.");
        }

        public void Dispense()
        {
            _machine.ReleaseBall();

            if (_machine.HasBolls())
            {
                _machine.SetState(new NoQuarterState(_machine));
                return;
            }
            
            _machine.SetState(new SoldOutState(_machine));
        }

        public override string ToString()
		{
			return "Sold state.";		
        }
    }
}