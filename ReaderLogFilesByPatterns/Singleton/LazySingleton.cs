namespace ReaderLogFilesByPatterns.Singleton
{
    using System;

    public sealed class LazySingleton
    {
        private static readonly Lazy<LazySingleton> _instance = new Lazy<LazySingleton>(() => new LazySingleton());

        public static LazySingleton Instance => _instance.Value;
    }
}