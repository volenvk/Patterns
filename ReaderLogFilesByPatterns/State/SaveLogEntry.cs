namespace ReaderLogFilesByPatterns.State
{
    using System;
    using Interfaces;
    using Models;

    public class SaveLogEntry : IStateExport
    {
        private readonly LogEntry _entry;

        public SaveLogEntry(LogEntry entry)
        {
            _entry = entry;
        }
        public void NextState(FileLogExport fileLogExport)
        {
            fileLogExport.SetState(null);
        }

        public void DoWork()
        {
            Save();
        }

        private void Save()
        {
            Console.WriteLine($"Save {nameof(_entry)}");
        }
    }
}