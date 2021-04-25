namespace ReaderLogFilesByPatterns.Models
{
    using Interfaces;

    public class SimpleLogEntry : LogEntry
    {
        public override void Accept(ILogEntryVisitor logEntryVisitor)
        {
            logEntryVisitor.Visit(this);
        }
    }
}