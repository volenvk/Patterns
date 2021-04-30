namespace ReaderLogFilesByPatterns.Command
{
    using System;

    public class Invoker
    {
        private readonly Action _action;

        public Invoker(Action action)
        {
            _action = action;
        }

        public void Invoke()
        {
            _action.Invoke();
        }
    }
}