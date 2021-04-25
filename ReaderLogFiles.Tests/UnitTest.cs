using NUnit.Framework;

namespace ReaderLogFiles.Tests
{
    using System;
    using ReaderLogFilesByPatterns.Models;
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
        
        [Test]
        public void TestDatabaseLogSaver()
        {
            // Arrange
            var logSaver = new DatabaseLogSaver();
            // Act
            
            // Assert
            Assert.Catch<NotImplementedException>(()=> logSaver.SaveLogEntry(new SimpleLogEntry()));
        }
    }
}