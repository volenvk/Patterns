using System;

namespace DesignPatterns.Decorator
{
    public class Soy : BaseCondiment
    {
		private const double _price = 0.20;

		public override string Description => Beverage.Description + ", Soy";

		public override double Price => _price;

		public Soy(BaseBeverage beverage) : base(beverage) {}

		public override void Accept(IBeverageVisitor priceVisitor)
		{
			priceVisitor.Visit(this);
		}
	}
}
