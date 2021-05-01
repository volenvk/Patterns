using System;
using System.Diagnostics;
using System.Threading.Tasks;
using ReaderLogFilesByPatterns.Interfaces;
using ReaderLogFilesByPatterns.Models;

namespace ReaderLogFilesByPatterns.Decorator
{
    public class TraceLogSaverDecorator : LogSaverDecorator
    {
        public TraceLogSaverDecorator(ILogSavers decorate) : base(decorate) {}

        public override async Task SaveLogEntry(string applicationId, LogEntry logEntry)
        {
            var sw = Stopwatch.StartNew();

            try
            {
                await _decorate.SaveLogEntry(applicationId, logEntry);
            }
            finally
            {
                Trace.TraceInformation("Операция сохранения завершена за {0}мс",
                sw.ElapsedMilliseconds);
            }
        }
    }
}
