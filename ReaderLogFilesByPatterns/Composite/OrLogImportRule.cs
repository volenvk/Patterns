using System.Linq;
using ReaderLogFilesByPatterns.Models;

namespace ReaderLogFilesByPatterns.Composite
{
	internal class OrLogImportRule : LogImportRule
	{
		private LogImportRule _left;
		private LogImportRule _logImportRule;

		public OrLogImportRule(LogImportRule left, LogImportRule logImportRule)
		{
			_left = left;
			_logImportRule = logImportRule;
		}

		public override bool ShouldImport(LogEntry logEntry)
		{
			return _left.ShouldImport(logEntry) || _logImportRule.ShouldImport(logEntry);
		}
	}
}