namespace ReaderLogFilesByPatterns.FactoryMethod
{
	using System.Collections.Generic;
	using System.IO;
	using Models;

    public class LogEntryParser
    {
        private readonly TextReader _reader;

        public LogEntryParser(TextReader reader)
        {
            _reader = reader;
        }

        public static LogEntry Parse(string data)
        {
            // Анализирует содержание data и создает нужный
            // экземпляр: ExceptionLogEntry или SimpleLogEntry            
            return new SimpleLogEntry();
        }

        public IEnumerable<LogEntry> Parse()
        {
            string line;
            while ((line = _reader.ReadLine()) != null)
            {
                yield return ParseLine(line);
            }
        }

        private LogEntry ParseLine(string line)
        {
            return new SimpleLogEntry();
        }
    }
}