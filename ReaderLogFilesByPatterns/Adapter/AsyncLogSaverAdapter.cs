using System;
using System.Threading.Tasks;
using ReaderLogFilesByPatterns.Factory;
using ReaderLogFilesByPatterns.Interfaces;
using ReaderLogFilesByPatterns.Models;

namespace ReaderLogFilesByPatterns.Adapter
{
    public class AsyncLogSaverAdapter : IAsyncLogSaver
    {
        private readonly LogSaver _logSaver;

        public AsyncLogSaverAdapter(LogSaver logSaver)
        {
            _logSaver = logSaver;
        }

        public Task SaveAsync(LogEntry logEntry)
        {
            return Task.Run(() => _logSaver.Save(new []{logEntry}));
        }
    }
}
