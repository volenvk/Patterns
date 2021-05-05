namespace DesignPatterns.Factory
{
    using Ingredients;

    public interface IPizzaIngredientFactory
    {
        Dough CreateDough();
        Sauce CreateSauce();
        Cheese CreateCheese();
    }
}