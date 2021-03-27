namespace BuildPatterns.FactoryMethod.Models
{
    using Interfaces;

    public class Magazine : ICover
    {
        public bool Open()
        {
            return true;
        }

        public string Read()
        {
            return "text and picture";
        }
    }
}