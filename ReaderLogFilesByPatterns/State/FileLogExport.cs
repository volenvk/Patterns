namespace ReaderLogFilesByPatterns.State
{
    using Interfaces;
    using Models;

    public class FileLogExport
    {
        private IStateExport _stateExport;

        public void Export(LogEntry entry)
        {
            SetState(new ReadLogEntry(entry));
            DoWork();
        }

        public void SetState(IStateExport state)
        {
            _stateExport = state;
        }

        private void DoWork()
        {
            while (_stateExport != null)
            {
                _stateExport.DoWork();
                _stateExport.NextState(this);
            }
        }
    }
}