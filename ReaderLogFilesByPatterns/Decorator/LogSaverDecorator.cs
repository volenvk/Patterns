using System;
using System.Threading.Tasks;
using ReaderLogFilesByPatterns.Interfaces;
using ReaderLogFilesByPatterns.Models;

namespace ReaderLogFilesByPatterns.Decorator
{
    public abstract class LogSaverDecorator
    {
        protected readonly ILogSavers _decorate;

        protected LogSaverDecorator(ILogSavers decoratee)
        {
            _decorate = decoratee;
        }
        
        public abstract Task SaveLogEntry(string applicationId, LogEntry logEntry);
    }
}
