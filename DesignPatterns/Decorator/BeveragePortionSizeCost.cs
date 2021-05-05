using System;

namespace DesignPatterns.Decorator
{
    public class BeveragePortionSizeCost : IPortionSizeCost
    {
		private readonly BaseBeverage _beverage;
		private const double PERCENT = 15;

		public BeveragePortionSizeCost(BaseBeverage beverage)
        {
			_beverage = beverage;
		}

        public double GetCost(PortionSize size)
        {
            switch (size)
            {
                case PortionSize.Big:
                    return 0.50 + GetCost();
                case PortionSize.Medium:
                    return 0.45 + GetCost();
                case PortionSize.Small:
                    return 0.30 + GetCost();
                default:
                    throw new ArgumentOutOfRangeException("cost not set");
            }
        }

        private double GetCost()
        {
            return ((double)_beverage.Price * PERCENT) / 100;
        }
    }
}
