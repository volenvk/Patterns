namespace BuildPatterns.FactoryMethod.Factories
{
    using Interfaces;
    using Models;

    public class BookLibrary : Library
    {
        protected override ICover CreateCover()
        {
            return new Book();
        }
    }
}