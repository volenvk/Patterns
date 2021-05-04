using System;

namespace DesignPatterns.Decorator
{
	public class Espresso : BaseBeverage
	{
		private const double _price = 1.99;
		protected override double Price => _price;
		public override string Description => "Espresso";

		public Espresso(PortionSize size, IPortionSizeCost portionSizeCost) : base(size, portionSizeCost) {}
	}
}
