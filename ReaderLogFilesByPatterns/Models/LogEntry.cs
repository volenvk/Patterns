namespace AllPatternsByLogFiles.Models
{
    using System;

    public class LogEntry
    {
        public DateTime DateTime { get; set; }
        public Severety Severety { get; set; }
        public string Message { get; set; }
    }
}