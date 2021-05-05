namespace DesignPatterns.TemplateMethod
{
    public abstract class CaffeineBeverage
    {
        public void Prepare()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddComponents();
        }
        
        protected abstract void Brew();
        
        protected abstract void AddComponents();

        private void BoilWater()
        {
            throw new System.NotImplementedException();
        }

        private void PourInCup()
        {
            throw new System.NotImplementedException();
        }
    }
}