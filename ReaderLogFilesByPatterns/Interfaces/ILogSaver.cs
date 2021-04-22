using System;
using System.Collections.Generic;
using ReaderLogFilesByPatterns.Models;

namespace ReaderLogFilesByPatterns.Interfaces
{
    public interface ILogSaver
    {
        void UploadLogEntries(IEnumerable<LogEntry> logEntries);

        void UploadExceptionEntries(IEnumerable<ExceptionLogEntry> exceptionEntries);
    }
}
