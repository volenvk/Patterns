using System;
using ReaderLogFilesByPatterns.Models;

namespace ReaderLogFilesByPatterns.Interfaces
{
    public interface ILogParser
    {
        LogEntry ParseLogEntry(string stringEntry);
    }
}
