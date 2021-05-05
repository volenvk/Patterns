namespace DesignPatterns.TemplateMethod
{
    public class Coffee : CaffeineBeverage
    {
        protected override void Brew()
        {
            BrewCoffeeGrinds();
        }

        protected override void AddComponents()
        {
            AddSugarOrMilk();
        }

        private void AddSugarOrMilk()
        {
            throw new System.NotImplementedException();
        }

        private void BrewCoffeeGrinds()
        {
            throw new System.NotImplementedException();
        }
    }
}