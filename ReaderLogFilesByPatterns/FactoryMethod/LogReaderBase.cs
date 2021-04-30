namespace ReaderLogFilesByPatterns.FactoryMethod
{
    using System.Collections.Generic;
    using System.IO;
    using Models;

    public abstract class LogReaderBase
    {
        public IEnumerable<LogEntry> Read()
        {
            using var stream = OpenLogSource();
            using var reader = new StreamReader(stream);
            string line = null;
            while ((line = reader.ReadLine()) != null)
            {
                yield return LogEntryParser.Parse(line);
            }
        }
        protected abstract Stream OpenLogSource();
    }
}