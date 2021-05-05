namespace DesignPatterns.Factory
{
    using System;

    public class CheesePizza : Pizza
    {
        private readonly IPizzaIngredientFactory _factory;

        public CheesePizza(IPizzaIngredientFactory factory)
        {
            _factory = factory;
            Name = nameof(CheesePizza);
        }
        
        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Dough = _factory.CreateDough();
            Sauce = _factory.CreateSauce();
            Cheese = _factory.CreateCheese();
        }

        public override void Bake()
        {
            throw new NotImplementedException();
        }

        public override void Cut()
        {
            throw new NotImplementedException();
        }

        public override void Box()
        {
            throw new NotImplementedException();
        }
    }
}