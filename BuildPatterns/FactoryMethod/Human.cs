namespace BuildPatterns.FactoryMethod
{
    using System;
    using Interfaces;

    public class Human
    {
        private IFactoryCover _factoryCover;
        
        public void TakeSomethingRead(IFactoryCover factoryCover)
        {
            _factoryCover = factoryCover;
        }

        public string Read()
        {
            if (_factoryCover == null)
                throw new ArgumentNullException(nameof(_factoryCover), "Take something for read");
            
            var cover = _factoryCover.Create();
            return cover.Open() ? cover.Read() : "I can't!";
        }
    }
}