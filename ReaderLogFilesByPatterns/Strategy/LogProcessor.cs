namespace AllPatternsByLogFiles.Strategy
{
    using System;
    using System.Collections.Generic;
    using Models;

    public class LogProcessor
    {
        private readonly Func<List<LogEntry>> _logImporter;
    }
}