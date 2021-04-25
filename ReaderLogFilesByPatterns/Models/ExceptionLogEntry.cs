namespace ReaderLogFilesByPatterns.Models
{
    using Interfaces;

    public class ExceptionLogEntry : LogEntry
    {
        public override void Accept(ILogEntryVisitor logEntryVisitor)
        {
            logEntryVisitor.Visit(this);
        }
    }
}
