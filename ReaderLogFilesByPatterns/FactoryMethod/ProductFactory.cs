namespace ReaderLogFilesByPatterns.FactoryMethod
{
    using System.Reflection;
    using System.Runtime.ExceptionServices;

    public static class ProductFactory
    {
        public static T Create<T>() where T : Product, new()
        {
            try
            {
                var t = new T();
                // Вызываем постобработку
                t.PostConstruction();
                return t;
            }
            catch (TargetInvocationException e)
            {
                // «разворачиваем» исключение и бросаем исходное
                var edi = ExceptionDispatchInfo.Capture(e.InnerException);
                edi.Throw();
                // эта точка недостижима, но компилятор об этом не знает!
                return default;
            }
        }
    }
}