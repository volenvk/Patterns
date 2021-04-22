namespace ReaderLogFilesByPatterns.Observer
{
    using System;

    public class LogEntryEventArgs : EventArgs
    {
        public string LogEntry {get; internal set;}
        
        public LogEntryEventArgs(string logEntry)
        {
            LogEntry = logEntry;
        }
    }
}