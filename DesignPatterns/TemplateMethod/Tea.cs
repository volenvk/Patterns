namespace DesignPatterns.TemplateMethod
{
    public class Tea : CaffeineBeverage
    {
        protected override void Brew()
        {
            SteepTeaBag();
        }

        protected override void AddComponents()
        {
            AddLemon();
        }

        private void SteepTeaBag()
        {    
            throw new System.NotImplementedException();
        }

        private void AddLemon()
        {
            throw new System.NotImplementedException();
        }    
    }
}