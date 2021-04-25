namespace ReaderLogFilesByPatterns.Visitor
{
    using System;
    using Interfaces;
    using Models;

    public class DatabaseLogSaver : ILogEntryVisitor
    {
        public void SaveLogEntry(LogEntry logEntry)
        {
            logEntry.Accept(this);
        }

        void ILogEntryVisitor.Visit(ExceptionLogEntry exceptionLogEntry)
        {
            SaveException(exceptionLogEntry);
        }

        void ILogEntryVisitor.Visit(SimpleLogEntry simpleLogEntry)
        {
            SaveSimpleLogEntry(simpleLogEntry);
        }

        private void SaveException(ExceptionLogEntry logEntry)
        {
            throw new NotImplementedException();
        }

        private void SaveSimpleLogEntry(SimpleLogEntry logEntry)
        {
            throw new NotImplementedException();
        }
    }
}