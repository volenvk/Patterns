using System.Linq;
using System;
using System.Collections.Generic;
using ReaderLogFilesByPatterns.Models;

namespace ReaderLogFilesByPatterns.TemplateMethod
{
    public abstract class LogReader
    {
        private int _currentPosition;

        public IEnumerable<LogEntry> ReadLogEntry()
        {
            return ReadEntries(ref _currentPosition).Select(ParseLogEntry);
        }

        protected abstract IEnumerable<string> ReadEntries(ref int position);

        protected abstract LogEntry ParseLogEntry(string strEntry);
    }
}
