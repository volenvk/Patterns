using System;

namespace DesignPatterns.Decorator
{
    public static class BeverageEx
    {
        public static double GetCost(this BaseBeverage beverage, PortionSize size)
        {        
            var visitor = new BeverageVisitor(beverage);

            return beverage.Price + visitor.PortionCost.GetCost(size);
        }

        public static double GetCost(this BaseCondiment condiment, PortionSize size)
        {
            var visitor = new BeverageVisitor(condiment);
            
            return condiment.Beverage.GetCost(size) + condiment.Price + visitor.PortionCost.GetCost(size);
        }
    }
}
