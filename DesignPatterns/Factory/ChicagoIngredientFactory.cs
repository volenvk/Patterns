namespace DesignPatterns.Factory
{
    using Ingredients;

    public class ChicagoIngredientFactory : IPizzaIngredientFactory
    {
        public Dough CreateDough()
        {
            throw new System.NotImplementedException();
        }

        public Sauce CreateSauce()
        {
            throw new System.NotImplementedException();
        }

        public Cheese CreateCheese()
        {
            throw new System.NotImplementedException();
        }
    }
}