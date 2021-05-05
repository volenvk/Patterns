using System;

namespace DesignPatterns.Decorator
{
	public class Espresso : BaseBeverage
	{
		private const double _price = 0.9;
		public override string Description => "Espresso";

		public override double Price => _price;

		public override void Accept(IBeverageVisitor priceVisitor)
        {
            priceVisitor.Visit(this);
        }
	}
}
