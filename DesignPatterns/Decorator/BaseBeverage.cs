using System;

namespace DesignPatterns.Decorator
{
    public abstract class BaseBeverage
    {
		public IPortionSizeCost PortionSizeCost { get; }
        public PortionSize Size { get; }
        public abstract string Description { get; }
        protected abstract double Price { get; }

		public BaseBeverage(PortionSize size, IPortionSizeCost portionSizeCost)
        {
            Size = size;
			PortionSizeCost = portionSizeCost;
		}

        public virtual double GetCost()
        {
            return Price + PortionSizeCost.GetCost(Size);
        }
    }
}
