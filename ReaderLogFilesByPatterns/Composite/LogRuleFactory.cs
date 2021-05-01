using System;
using ReaderLogFilesByPatterns.Models;

namespace ReaderLogFilesByPatterns.Composite
{
    public static class LogRuleFactory
    {
        public static LogImportRule Import(Func<LogEntry, bool> predicate)
        {
            return new SingleLogImportRule(predicate);
        }

        public static LogImportRule Or(this LogImportRule left, Func<LogEntry, bool> predicate)
        {
            return new OrLogImportRule(left, Import(predicate));
        }

        public static LogImportRule And(this LogImportRule left, Func<LogEntry, bool> predicate)
        {
            return new AndLogImportRule(left, Import(predicate));
        }

        public static LogImportRule RejectOldEntriesWithLowSeverity(TimeSpan period)
        {
            return
            // Импортируем исключения
            Import(le => le is ExceptionLogEntry)
            // или старые сообщения с высокой важностью
            .Or(le => (DateTime.Now - le.EntryDateTime) > period)
            .And(le => le.Severity >= Severity.Warning)
            // или новые сообщения с любой важностью
            .Or(le => (DateTime.Now - le.EntryDateTime) <= period);
        }
    }
}
