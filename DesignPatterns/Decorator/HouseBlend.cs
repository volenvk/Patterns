using System;

namespace DesignPatterns.Decorator
{
	public class HouseBlend : BaseBeverage
	{
		private const double _price = 0.89;

		protected override double Price => _price;

		public override string Description => "House Blend Coffee";

		public HouseBlend(PortionSize size, IPortionSizeCost portionSizeCost) : base(size, portionSizeCost) {}

	}
}
