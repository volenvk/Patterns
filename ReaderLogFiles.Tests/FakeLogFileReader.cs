namespace ReaderLogFiles.Tests
{
    using System.IO;
    using ReaderLogFilesByPatterns.TemplateMethod;

    public class FakeLogFileReader : LogFileReaderBase
    {
        private readonly MemoryStream _mockStream;
        
        public FakeLogFileReader(MemoryStream mockStream)
            : base(string.Empty)
        {
            _mockStream = mockStream;
        }
        
        protected override Stream OpenFileStream(string fileName)
        {
            return _mockStream;
        }
    }
}