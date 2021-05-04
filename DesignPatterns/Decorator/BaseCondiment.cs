using System;

namespace DesignPatterns.Decorator
{
    public abstract class BaseCondiment : BaseBeverage
    {
        protected readonly BaseBeverage Beverage;
		private readonly IPortionSizeCost _portionCost;

        public BaseCondiment(BaseBeverage beverage, IPortionSizeCost portionSizeCost) : base(beverage.Size, beverage.PortionSizeCost)
        {
            Beverage = beverage;
			_portionCost = portionSizeCost;
        }

        public override double GetCost()
		{
			return Beverage.GetCost() + Price + _portionCost.GetCost(Beverage.Size);
		}
    }
}
