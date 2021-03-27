namespace BuildPatterns.FactoryMethod.Factories
{
    using Interfaces;

    public abstract class Library
    {
        public string Read()
        {
            var cover = CreateCover();
            return cover.Open() ? cover.Read() : string.Empty;
        }

        protected abstract ICover CreateCover();
    }
}