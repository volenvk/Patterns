namespace ReaderLogFilesByPatterns.Observer
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.IO;
    using System.Threading;
    using Interfaces;

    public class LogFileReader : IDisposable
    {
        private readonly ILogFileReaderObserver _observer;
        private readonly string _logFileName;
        private readonly Action<string> _logEntrySubscriber;
        private readonly static TimeSpan CheckFileInterval = TimeSpan.FromSeconds(5);
        private readonly Timer _timer;
        
        public event EventHandler<LogEntryEventArgs> OnNewLogEntry;

        public string LogFileName { get { return _logFileName; } }
        
        public LogFileReader(string logFileName)
        {
            _logFileName = logFileName;
        }
        
        public LogFileReader(string logFileName, Action<string> logEntrySubscriber)
        {
            Contract.Requires(File.Exists(logFileName));
            _logEntrySubscriber = logEntrySubscriber;
            _timer = new Timer(CheckFile, new AutoResetEvent(false), CheckFileInterval, CheckFileInterval);
        }

        public LogFileReader(string logFileName, ILogFileReaderObserver observer)
        {
            _logFileName = logFileName;
            _observer = observer;
        }

        public void Dispose()
        {
            _timer.Dispose();
        }
        
        // Добавлена дополнительная логика, которая определяет,
        // что логер перестал писать в текущий лог-файл и переключился
        // на новый.

        private void DetectThatNewFileWasCreated()
        {
            // Метод вызывается по таймеру
            if (NewLogFileWasCreated())
                _observer.FileWasRolled(_logFileName, GetNewLogFileName());
        }

        private bool NewLogFileWasCreated()
        {
            throw new NotImplementedException();
        }
    
        private string GetNewLogFileName()
        {
            throw new NotImplementedException();
        }

        private void CheckFile(object value)
        {
            foreach(var logEntry in ReadNewLogEntries())
            {
                RaiseNewLogEntry(logEntry);
            }
        }
        
        private void RaiseNewLogEntry(string logEntry)
        {
            var handler = OnNewLogEntry;
            handler?.Invoke(this, new LogEntryEventArgs(logEntry));
        }
        
        private IEnumerable<string> ReadNewLogEntries()
        {
            // ...
            // Читаем новые записи из файла,
            // которые появились с момента последнего чтения
            _logEntrySubscriber.Invoke(_logFileName);
            throw new NotImplementedException();
        }
    }
}