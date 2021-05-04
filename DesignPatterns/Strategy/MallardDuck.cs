using System;

namespace DesignPatterns.Strategy
{
	public class MallardDuck : Duck
	{
		public override void Display()
		{
			Console.WriteLine("Mallard duck");
		}
	}
}
