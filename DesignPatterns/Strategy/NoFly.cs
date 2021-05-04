using System;

namespace DesignPatterns.Strategy
{
	public class NoFly : IFlyBehavior
	{
		public void Fly()
		{
			Console.WriteLine("No Fly");
		}
	}
}
