using ReaderLogFilesByPatterns.Models;

namespace ReaderLogFilesByPatterns.Composite
{
    public abstract class LogImportRule
    {
        public abstract bool ShouldImport(LogEntry logEntry);
    }
}
