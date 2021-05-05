using System;

namespace DesignPatterns.Decorator
{
    public abstract class BaseCondiment : BaseBeverage
    {
        public BaseBeverage Beverage {get;}

        public BaseCondiment(BaseBeverage beverage)
        {
            Beverage = beverage;
        }
    }
}
