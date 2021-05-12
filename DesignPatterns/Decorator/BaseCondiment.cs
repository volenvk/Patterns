namespace DesignPatterns.Decorator
{
    public abstract class BaseCondiment : BaseBeverage
    {
        public BaseBeverage Beverage {get;}

        protected BaseCondiment(BaseBeverage beverage)
        {
            Beverage = beverage;
        }
    }
}
