using NUnit.Framework;

namespace ReaderLogFiles.Tests
{
    using System;
    using System.IO;
    using System.Linq;
    using ReaderLogFilesByPatterns.Command;
	using ReaderLogFilesByPatterns.Composite;
	using ReaderLogFilesByPatterns.FactoryMethod;
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
                Severity = Severity.Warning,
                EntryDateTime = DateTime.Now
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

        [Test]
        public void TestTemplateMethod()
        {
            // Act
            var p = ProductFactory.Create<ConcreteProduct>();
            
            // Assert
            Assert.IsNotNull(p);
        }

        [Test]
        public void TestComposite()
        {
            var rule = LogRuleFactory.RejectOldEntriesWithLowSeverity(TimeSpan.FromDays(7));
            LogEntry logEntry = new ExceptionLogEntry()
            {
                Severity = Severity.Warning,
                EntryDateTime = DateTime.Now.AddDays(-5),
                Message = "Test"
            };

            // Assert
            Assert.IsTrue(rule.ShouldImport(logEntry));
            logEntry = new SimpleLogEntry(){ EntryDateTime = DateTime.Now.AddDays(-10) };
            // Assert
            Assert.IsFalse(rule.ShouldImport(logEntry));
            logEntry.Severity = Severity.Critical;
            // Assert
            Assert.IsFalse(rule.ShouldImport(logEntry));
            logEntry = new SimpleLogEntry()
            {
                EntryDateTime = DateTime.Now.AddDays(-5),
                Severity = Severity.Debug
            };
            Assert.IsTrue(rule.ShouldImport(logEntry));
        }
    }
}