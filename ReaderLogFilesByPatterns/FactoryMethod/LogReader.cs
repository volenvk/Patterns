namespace ReaderLogFilesByPatterns.FactoryMethod
{
    using System;
    using System.IO;

    public class LogReader : LogReaderBase
    {
        private readonly Func<Stream> _streamFactory;
        private LogReader(Func<Stream> streamFactory)
        {
            _streamFactory = streamFactory;
        }
        
        public static LogReader FromFile(string fileName)
        {
            Func<Stream> factory = () => new FileStream(fileName, FileMode.Open);
            return new LogReader(factory);
        }
        public static LogReader FromStream(Stream stream)
        {
            Func<Stream> factory = () => stream;
            return new LogReader(factory);
        }
        
        protected override Stream OpenLogSource() => _streamFactory();
    }
}
