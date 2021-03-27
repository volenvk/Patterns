namespace BuildPatterns.FactoryMethod.Factories
{
    using Interfaces;
    using Models;

    public class MagazineLibrary : Library
    {
        protected override ICover CreateCover()
        {
            return new Magazine();
        }
    }
}