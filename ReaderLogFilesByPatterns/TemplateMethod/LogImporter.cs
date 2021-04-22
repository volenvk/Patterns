using System.Collections.Generic;
using ReaderLogFilesByPatterns.Models;

namespace ReaderLogFilesByPatterns.TemplateMethod
{
	public abstract class LogImporter
	{
		protected abstract LogEntry ParseLogEntry(string stringEntry);

		protected abstract IEnumerable<string> ReadEntries(ref int position);
	}
}