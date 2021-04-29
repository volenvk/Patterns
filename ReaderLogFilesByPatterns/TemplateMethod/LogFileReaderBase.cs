using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using ReaderLogFilesByPatterns.Interfaces;
using ReaderLogFilesByPatterns.Models;

namespace ReaderLogFilesByPatterns.TemplateMethod
{
	public abstract class LogFileReaderBase : LogImporter, IDisposable
	{
        private readonly Lazy<Stream> _stream;
		private readonly ILogParser _logParser;

		protected LogFileReaderBase(string fileName)
        {
            _stream = new Lazy<Stream>(() => new FileStream(fileName, FileMode.Open));
        }

        protected LogFileReaderBase(string fileName, ILogParser logParser) : this(fileName)
        {
            _logParser = logParser;
        }
        
        protected virtual Stream OpenFileStream(string fileName)
        {
            return new FileStream(fileName, FileMode.Open);
        }

        protected override sealed IEnumerable<string> ReadEntries(ref int position)
        {
            Contract.Assert(_stream.Value.CanSeek);
            if (_stream.Value.Position != position)
            {
                _stream.Value.Seek(position, SeekOrigin.Begin);
            }

            return ReadLineByLine(_stream.Value, ref position);
        }

        protected override LogEntry ParseLogEntry(string stringEntry)
        {
            return _logParser.ParseLogEntry(stringEntry);
        }

        private IEnumerable<string> ReadLineByLine(Stream stream, ref int position)
        {
            // Построчное чтение из потока ввода/вывода
                byte[] array = new byte[stream.Length];
                // считываем данные
                stream.Read(array, position, array.Length);
                // декодируем байты
                return System.Text.Encoding.Default.GetString(array).Split();
        }
        
		public void Dispose()
		{
			if (_stream.IsValueCreated)
            {
                _stream.Value.Close();
            }
		}

        public abstract IEnumerable<LogEntry> ReadLogEntry();
    }
}
