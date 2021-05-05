using System;

namespace DesignPatterns.Decorator
{
	public class HouseBlend : BaseBeverage
	{
		private const double _price = 1.5;
		public override string Description => "House Blend Coffee";

		public override double Price => _price;

		public override void Accept(IBeverageVisitor priceVisitor)
        {
            priceVisitor.Visit(this);
        }
	}
}
