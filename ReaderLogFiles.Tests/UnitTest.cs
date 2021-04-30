using NUnit.Framework;

namespace ReaderLogFiles.Tests
{
    using System;
    using System.IO;
    using System.Linq;
    using ReaderLogFilesByPatterns.Command;
    using ReaderLogFilesByPatterns.Models;
    using ReaderLogFilesByPatterns.State;
    using ReaderLogFilesByPatterns.TemplateMethod;
    using ReaderLogFilesByPatterns.Visitor;

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

        private MemoryStream GetMemoryStreamWithOneElement()
        {
            return new MemoryStream();
        }

        [Test]
        public void TestDatabaseLogSaver()
        {
            // Arrange
            var logSaver = new DatabaseLogSaver();
            // Act
            
            // Assert
            Assert.Catch<NotImplementedException>(()=> logSaver.SaveLogEntry(new SimpleLogEntry()));
        }
        
        [Test]
        public void TestFileLogExport()
        {
            // Arrange
            var logExport = new FileLogExport();
            // Act
            logExport.Export(new SimpleLogEntry
            {
                Message = "Test",
                Severity = Severity.Information,
                DateTime = DateTime.Now
            });
            
            // Assert
            Assert.Pass();
        }

        [Test]
        public void TestCommand()
        {
            var receiver = new Receiver();
            var invoker = new Invoker(receiver.Read);

            // Act
            invoker.Invoke();

            // Assert
            Assert.Pass();
        }
    }
}