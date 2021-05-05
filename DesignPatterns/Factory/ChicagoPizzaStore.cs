namespace DesignPatterns.Factory
{
    using System;

    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new CheesePizza(new ChicagoIngredientFactory());
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}