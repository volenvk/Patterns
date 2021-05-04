using System;

namespace DesignPatterns.Strategy
{
	public class FlyWings : IFlyBehavior
	{
		public void Fly()
		{
			Console.WriteLine("Fly");
		}
	}
}
