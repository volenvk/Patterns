using System;
using System.Threading.Tasks;
using ReaderLogFilesByPatterns.Interfaces;
using ReaderLogFilesByPatterns.Models;

namespace ReaderLogFilesByPatterns.Decorator
{
    public sealed class ElasticsearchLogSaver : ILogSavers
    {
        public Task SaveLogEntry(string applicationId, LogEntry logEntry)
        {
            // Сохраняем переданную запись в Elasticsearch
            return Task.FromResult<object>(null);
        }
    }
}
