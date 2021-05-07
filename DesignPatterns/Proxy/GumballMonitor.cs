using System;

namespace DesignPatterns.Proxy
{
    public class GumballMonitor
    {
		private readonly GumballMachineLocation _machine;

		public GumballMonitor(GumballMachineLocation machine)
        {
			_machine = machine;
		}

        public void PrintReport()
        {
            Console.WriteLine($"Location: {_machine.Location}, Gumballs: {_machine.Gumballs}, State: {_machine.MachineState}");
        }
    }
}
