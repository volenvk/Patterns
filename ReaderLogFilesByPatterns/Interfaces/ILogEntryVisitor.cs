namespace ReaderLogFilesByPatterns.Interfaces
{
    using Models;

    public interface ILogEntryVisitor
    {
        void Visit(ExceptionLogEntry exceptionLogEntry);
        void Visit(SimpleLogEntry simpleLogEntry);
    }
}