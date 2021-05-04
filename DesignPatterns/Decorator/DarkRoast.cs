using System;

namespace DesignPatterns.Decorator
{
	public class DarkRoast : BaseBeverage
	{
		private const double _price = 1.20;
		protected override double Price => _price;
		public override string Description => "Most excellent dark roast.";

		public DarkRoast(PortionSize size, IPortionSizeCost portionSizeCost) : base(size, portionSizeCost) {}
	}
}
