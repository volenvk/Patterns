namespace ReaderLogFilesByPatterns.Interfaces
{
    using State;

    public interface IStateExport
    {
        void NextState(FileLogExport fileLogExport);

        void DoWork();
    }
}