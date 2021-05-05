using System;

namespace DesignPatterns.Decorator
{
    public class CondimentPortionSizeCost : IPortionSizeCost
    {
		private readonly BaseCondiment _condiment;
        private const double PERCENT = 5;

		public CondimentPortionSizeCost(BaseCondiment condiment)
        {
			_condiment = condiment;
		}

        public double GetCost(PortionSize size)
        {
            switch (size)
            {
                case PortionSize.Big:
                    return 0.20 + GetCost();
                case PortionSize.Medium:
                    return 0.15 + GetCost();
                case PortionSize.Small:
                    return 0.10 + GetCost();
                default:
                    throw new ArgumentOutOfRangeException("cost not set");
            }
        }

        private double GetCost()
        {
            return ((double)_condiment.Price * PERCENT) / 100;
        }
    }
}
