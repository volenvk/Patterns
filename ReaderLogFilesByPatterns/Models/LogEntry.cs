namespace ReaderLogFilesByPatterns.Models
{
    using System;

    public class LogEntry
    {
        public DateTime DateTime { get; set; }
        public Severity Severety { get; set; }
        public string Message { get; set; }
    }
}