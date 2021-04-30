using System.Collections.Generic;
using ReaderLogFilesByPatterns.Models;

namespace ReaderLogFilesByPatterns.TemplateMethod
{
	using FactoryMethod;

	public abstract class LogImporter : LogReaderBase
	{
		protected abstract LogEntry ParseLogEntry(string stringEntry);

		protected abstract IEnumerable<string> ReadEntries(ref int position);
	}
}