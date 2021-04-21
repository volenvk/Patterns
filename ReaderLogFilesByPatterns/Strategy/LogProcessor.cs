namespace ReaderLogFilesByPatterns.Strategy
{
    using System;
    using System.Collections.Generic;
    using Models;

    public class LogProcessor
    {
        private readonly Func<List<LogEntry>> _logImporter;

        public LogProcessor(Func<List<LogEntry>> logImporter)
        {
            _logImporter = logImporter;
        }

        public void ProcessLogs()
        {
            foreach (var logEntry in _logImporter.Invoke())
            {
                SaveLogEntry(logEntry);
            }
        }

        private void SaveLogEntry(LogEntry entry)
        {
            throw new NotImplementedException();
        }
    }
}