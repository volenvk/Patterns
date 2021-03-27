namespace BuildPatterns.FactoryMethod.Factories
{
    using Interfaces;
    using Models;

    public class FactoryBook : IFactoryCover
    {
        public ICover Create()
        {
            return new Book();
        }
    }
}