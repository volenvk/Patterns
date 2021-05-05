namespace DesignPatterns.Factory
{
    using Ingredients;

    public abstract class Pizza
    {
        public string Name { get; set; }
        public Dough Dough  { get; set; }
        public Sauce Sauce { get; set; }
        public Cheese Cheese { get; set; }
        public abstract void Prepare();

        public abstract void Bake();

        public abstract void Cut();

        public abstract void Box();
    }
}