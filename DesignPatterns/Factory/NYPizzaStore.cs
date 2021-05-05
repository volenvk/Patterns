namespace DesignPatterns.Factory
{
    using System;

    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new CheesePizza(new NYPizzaIngredientFactory());
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}