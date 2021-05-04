using System;

namespace DesignPatterns.Decorator
{
	public class Mocha : BaseCondiment
	{
		private const double _price = 0.50;

		public Mocha(BaseBeverage beverage, IPortionSizeCost portionSizeCost) : base(beverage, portionSizeCost) {}

		public override string Description => Beverage.Description + ", Mocha";

		protected override double Price => _price;
	}
}
