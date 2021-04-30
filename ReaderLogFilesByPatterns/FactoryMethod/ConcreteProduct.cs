namespace ReaderLogFilesByPatterns.FactoryMethod
{
    using System;
    using TemplateMethod;

    public class ConcreteProduct : Product
    {
        public ConcreteProduct() {}
        
        protected internal override void PostConstruction()
        {
            Console.WriteLine("ConcreteProduct: post construction");
        }
    }
}