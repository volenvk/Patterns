namespace BuildPatterns.FactoryMethod.Factories
{
    using Interfaces;
    using Models;

    public class FactoryMagazine : IFactoryCover
    {
        public ICover Create()
        {
            return new Magazine();
        }
    }
}