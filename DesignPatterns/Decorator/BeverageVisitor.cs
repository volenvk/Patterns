using System;

namespace DesignPatterns.Decorator
{
	public class BeverageVisitor : IBeverageVisitor
	{
        public IPortionSizeCost PortionCost {get; private set;}

        public BeverageVisitor(BaseBeverage beverage)
        {
            beverage.Accept(this);
        }

		public void Visit(Soy soy)
		{
			PortionCost = new CondimentPortionSizeCost(soy);
		}

		public void Visit(Mocha mocha)
		{
			PortionCost = new CondimentPortionSizeCost(mocha);
		}

		void IBeverageVisitor.Visit(DarkRoast darkRoast)
		{
            PortionCost = new BeveragePortionSizeCost(darkRoast);
		}

		void IBeverageVisitor.Visit(Espresso espresso)
		{
			PortionCost = new BeveragePortionSizeCost(espresso);
		}

		void IBeverageVisitor.Visit(HouseBlend houseBlend)
		{
			PortionCost = new BeveragePortionSizeCost(houseBlend);
		}
	}
}
