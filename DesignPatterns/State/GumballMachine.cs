namespace DesignPatterns.State
{
    using System;

    public class GumballMachine
    {
        protected int GumballCount;
        protected IState State;

        public GumballMachine(int count)
        {
            GumballCount = count;
            State = new NoQuarterState(this);
        }
        
        public void SetState(IState state)
        {
            State = state;
        }

        public bool HasBolls() => GumballCount > 0;

        public void InsertQuarter()
        {
            State.InsertQuarter();
        }

        public void EjectQuarter()
        {
            State.EjectQuarter();
        }

        public void TurnCrank()
        {
            State.TurnCrank();
            State.Dispense();
        }

        public void ReleaseBall()
        {
            GumballCount--;
            Console.WriteLine("Release ball!");
        }
    }
}