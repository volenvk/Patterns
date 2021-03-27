namespace BuildPatterns.FactoryMethod.Factories
{
    using Interfaces;
    using Models;

    public class FactoryAtlas : IFactoryCover
    {
        public ICover Create()
        {
            return new Atlas();
        }
    }
}