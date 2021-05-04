using System;

namespace DesignPatterns.Observable
{
    public interface ISubject
    {
        void Register(IObserv o);
        void Remove(IObserv o);
        void Notify();
    }
}
