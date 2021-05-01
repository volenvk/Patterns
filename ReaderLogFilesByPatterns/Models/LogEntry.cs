namespace ReaderLogFilesByPatterns.Models
{
    using System;
    using Interfaces;

    public abstract class LogEntry
    {
        public DateTime EntryDateTime { get; set; }
        public Severity Severity { get; set; }
        public string Message { get; set; }
        
        public abstract void Accept(ILogEntryVisitor logEntryVisitor);

        public static LogEntry Parse(string line)
        {
            throw new NotImplementedException();
        }
    }
}