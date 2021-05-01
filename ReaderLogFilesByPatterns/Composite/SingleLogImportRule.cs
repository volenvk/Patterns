using System;
using ReaderLogFilesByPatterns.Models;

namespace ReaderLogFilesByPatterns.Composite
{
	internal class SingleLogImportRule : LogImportRule
	{
		private Func<LogEntry, bool> _predicate;

		public SingleLogImportRule(Func<LogEntry, bool> predicate)
		{
			_predicate = predicate;
		}

		public override bool ShouldImport(LogEntry logEntry)
		{
			return _predicate(logEntry);
		}
	}
}