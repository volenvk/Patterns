namespace ReaderLogFilesByPatterns.TemplateMethod
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Diagnostics.Contracts;
    using Models;

    [ExcludeFromCodeCoverage, ContractClassFor(typeof (LogImporter))]
    public abstract class LogImporterContract : LogImporter
    {
        protected override IEnumerable<string> ReadEntries(ref int position)
        {
            Contract.Ensures(Contract.Result<IEnumerable<string>>() != null);
            Contract.Ensures(
                Contract.ValueAtReturn(out position) >=
                Contract.OldValue(position));
            throw new System.NotImplementedException();
        }
        
        protected override LogEntry ParseLogEntry(string stringEntry)
        {
            Contract.Requires(stringEntry != null);
            Contract.Ensures(Contract.Result<LogEntry>() != null);
            throw new System.NotImplementedException();
        }
    }
}