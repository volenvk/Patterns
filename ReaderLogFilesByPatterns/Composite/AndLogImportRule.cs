using ReaderLogFilesByPatterns.Models;

namespace ReaderLogFilesByPatterns.Composite
{
	internal class AndLogImportRule : LogImportRule
	{
		private LogImportRule _left;
		private LogImportRule _logImportRule;

		public AndLogImportRule(LogImportRule left, LogImportRule logImportRule)
		{
			this._left = left;
			this._logImportRule = logImportRule;
		}

		public override bool ShouldImport(LogEntry logEntry)
		{
			return _left.ShouldImport(logEntry) && _logImportRule.ShouldImport(logEntry);
		}
	}
}