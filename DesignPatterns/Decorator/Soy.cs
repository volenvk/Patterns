using System;

namespace DesignPatterns.Decorator
{
    public class Soy : BaseCondiment
    {
		private const double _price = 0.20;

		public Soy(BaseBeverage beverage, IPortionSizeCost portionSizeCost) : base(beverage, portionSizeCost) {}
		public override string Description => Beverage.Description + ", Soy";

		protected override double Price => _price;
	}
}
