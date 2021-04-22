using System;
using System.Text;
using ReaderLogFilesByPatterns.TemplateMethod;

namespace ReaderLogFilesByPatterns.Extensions
{
    public static class LogEntryBaseEx
    {
        public static string GetText(this LogEntryBase logEntry)
        {
            var sb = new StringBuilder();
            sb.AppendFormat("[{0}] ", logEntry.EntryDateTime)
            .AppendFormat("[{0}] ", logEntry.Severity)
            .AppendLine(logEntry.Message)
            .AppendLine(logEntry.AdditionalInformation);
            return sb.ToString();
        }
    }
}
