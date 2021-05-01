using System;
using System.Threading.Tasks;
using ReaderLogFilesByPatterns.Models;

namespace ReaderLogFilesByPatterns.Interfaces
{
    public interface ILogSavers
    {
        Task SaveLogEntry(string applicationId, LogEntry logEntry);
    }
}
