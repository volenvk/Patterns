namespace ReaderLogFilesByPatterns.Factory
{
    using System.Collections.Generic;
    using System.Data.Common;
    using Models;

    public class LogSaver
    {
        private readonly DbProviderFactory _factory;
        public const string SqlClient = "System.Data.SqlClient";
        
        public LogSaver(DbProviderFactory factory)
        {
            _factory = factory;
        }
        
        public static DbProviderFactory GetDbProviderFactory(string factoryName) => 
            DbProviderFactories.GetFactory(factoryName);

        public void Save(IEnumerable<LogEntry> logEntries)
        {
            using var connection = _factory.CreateConnection();
            SetConnectionString(connection);
            using var command = _factory.CreateCommand();
            SetCommandArguments(logEntries);
            command?.ExecuteNonQuery();
        }

        private void SetConnectionString(DbConnection connection)
        {
            
        }

        private void SetCommandArguments(IEnumerable<LogEntry> logEntry)
        {
            
        }
    }
}