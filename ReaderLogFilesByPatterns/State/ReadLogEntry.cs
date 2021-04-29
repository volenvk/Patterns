namespace ReaderLogFilesByPatterns.State
{
    using System;
    using Interfaces;
    using Models;

    public class ReadLogEntry : IStateExport
    {
        private readonly LogEntry _entry;

        public ReadLogEntry(LogEntry entry)
        {
            _entry = entry;
        }
        
        public void NextState(FileLogExport fileLogExport)
        {
            fileLogExport?.SetState(new SaveLogEntry(_entry));
        }

        public void DoWork()
        {
            Read();
        }

        private void Read()
        { 
            Console.WriteLine($"Read message: {_entry.Message}");
        }
    }
}    