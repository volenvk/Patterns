using System;
using System.Threading.Tasks;
using ReaderLogFilesByPatterns.Models;

namespace ReaderLogFilesByPatterns.Interfaces
{
    public interface IAsyncLogSaver
    {
        Task SaveAsync(LogEntry logEntry);
    }
}
