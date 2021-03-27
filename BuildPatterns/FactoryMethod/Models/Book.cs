namespace BuildPatterns.FactoryMethod.Models
{
    using Interfaces;

    public class Book : ICover
    {
        public bool Open()
        {
            return true;
        }

        public string Read()
        {
            return "text";
        }
    }
}