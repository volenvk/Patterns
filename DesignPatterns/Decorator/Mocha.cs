using System;

namespace DesignPatterns.Decorator
{
	public class Mocha : BaseCondiment
	{
		private const double _price = 0.50;

		public Mocha(BaseBeverage beverage) : base(beverage) {}

		public override string Description => Beverage.Description + ", Mocha";

		public override double Price => _price;

		public override void Accept(IBeverageVisitor priceVisitor)
		{
			priceVisitor.Visit(this);
		}
	}
}
