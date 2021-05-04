using System;

namespace DesignPatterns.Strategy
{
    public abstract class Duck
    {
        private IFlyBehavior _flyBehavior;
        private IQuackBehavior _quackBehavior;

        public abstract void Display();

        public void SetFlyBehavior(IFlyBehavior flyBehavior) => _flyBehavior = flyBehavior;

        public void SetQuackBehavior(IQuackBehavior quackBehavior) => _quackBehavior = quackBehavior;

        public void PerformFly() => _flyBehavior?.Fly();

        public void PerformQuack() => _quackBehavior?.Quack();

        public void Swim() => Console.WriteLine("Swim");
    }
}
