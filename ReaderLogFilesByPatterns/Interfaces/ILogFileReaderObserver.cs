namespace ReaderLogFilesByPatterns.Interfaces
{
    public interface ILogFileReaderObserver
    {
        void NewLogEntry(string logEntry);
        void FileWasRolled(string oldLogFile, string newLogFile);
    }
}