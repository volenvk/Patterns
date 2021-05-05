using System;

namespace DesignPatterns.Decorator
{
    public abstract class BaseBeverage
    {
        public abstract string Description { get; }
        public abstract double Price { get; }

        public abstract void Accept(IBeverageVisitor priceVisitor);
    }
}
