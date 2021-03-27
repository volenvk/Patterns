namespace BuildPatterns.FactoryMethod.Models
{
    using Interfaces;
    
    public class Atlas : ICover
    {
        public bool Open()
        {
            return true;
        }

        public string Read()
        {
            return "map";
        }
    }
}