namespace ReaderLogFilesByPatterns.FactoryMethod
{
    using Models;

    public static class LogEntryParser
    {
        public static LogEntry Parse(string data)
        {
            // Анализирует содержание data и создает нужный
            // экземпляр: ExceptionLogEntry или SimpleLogEntry
            
            return new SimpleLogEntry();
        }
    }
}