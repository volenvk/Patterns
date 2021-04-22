namespace ReaderLogFilesByPatterns.Observer
{
    public class LogForwarder
    {
        public LogForwarder(LogFileReader logFileReader)
        {
            logFileReader.OnNewLogEntry += HandleNewLogEntry;
        }
        
        private void HandleNewLogEntry(object sender, LogEntryEventArgs ea)
        {
            var logEntry = ea.LogEntry;
            var logFile = ((LogFileReader)sender).LogFileName;
            // Обрабатываем logEntry с учетом имени файла
        }
    }
}