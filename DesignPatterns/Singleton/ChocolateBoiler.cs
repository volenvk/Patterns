namespace DesignPatterns.Singleton
{
    using System;

    public class ChocolateBoiler
    {
        private static readonly Lazy<ChocolateBoiler> _instance = new Lazy<ChocolateBoiler>(() => new ChocolateBoiler());

        private bool _empty;
        private bool _boiled;

        public static ChocolateBoiler Init()
        {
            return _instance.Value;
        }
        
        private ChocolateBoiler()
        {
            _empty = true;
            _boiled = false;
        }

        public void Fill()
        {
            if (IsEmpty())
            {
                _empty = false;
                _boiled = false;
                // Заполнение нагревателя молочно-шоколадной смесью
            }
        }

        public void Drain()
        {
            if (!IsEmpty() && IsBoiled())
            {
                // Слить нагретое молоко и шоколад
                _empty = true;
            }
        }

        public void Boil()
        {
            if (!IsEmpty() && !IsBoiled())
            {
                // Довести содержимое до кипения
                _boiled = true;
            }
        }

        private bool IsBoiled()
        {
            return _boiled;
        }

        private bool IsEmpty()
        {
            return _empty;
        }
    }
}