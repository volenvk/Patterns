using System;

namespace DesignPatterns.Decorator
{
	public class DarkRoast : BaseBeverage
	{
		private const double _price = 1.2;
		public override string Description => "Most excellent dark roast.";

		public override double Price => _price;

		public override void Accept(IBeverageVisitor priceVisitor)
        {
            priceVisitor.Visit(this);
        }
	}
}
