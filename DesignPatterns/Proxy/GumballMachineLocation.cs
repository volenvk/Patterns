using System;
using DesignPatterns.State;

namespace DesignPatterns.Proxy
{
    public class GumballMachineLocation : GumballMachine
    {
        public string Location {get; private set;}

        public int Gumballs => GumballCount;

        public string MachineState => State.ToString();

        public GumballMachineLocation(string location, int count) : base(count)
        {
            Location = location;
        }
    }
}
