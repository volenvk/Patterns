using NUnit.Framework;

namespace ReaderLogFiles.Tests
{
    using ReaderLogFilesByPatterns.TemplateMethod;

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestFakedMemoryStreamProvidedOneElement()
        {
            // Arrange
            LogFileReaderBase cut = new FakeLogFileReader(GetMemoryStreamWithOneElement());
            // Act
            var logEntries = cut.ReadLogEntry();
            // Assert
            Assert.That(logEntries.Count(), Is.EqualTo(1));
        }
    }
}