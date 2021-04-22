namespace ReaderLogFilesByPatterns.TemplateMethod
{
	using System;
	using System.Collections.Generic;
	using Interfaces;
	using Models;
	using WCF;

	public class LogSaverProxy : ILogSaver
	{
		class LogSaverClient : ClientBase<ILogSaver>
        {
            public ILogSaver LogSaver() => Channel;
            
        }

		public void UploadLogEntries(IEnumerable<LogEntry> logEntries)
		{
			UseProxyClient(c => c.UploadLogEntries(logEntries));
		}

		public void UploadExceptionEntries(IEnumerable<ExceptionLogEntry> exceptionEntries)
		{
			UseProxyClient(c => c.UploadExceptionEntries(exceptionEntries));
		}

		private void UseProxyClient(Action<ILogSaver> accessor)
		{
			var client = new LogSaverClient();

            try
            {
                accessor(client.LogSaver());
                client.Close();
            }
            catch(CommunicationException e)
            {
                client.Abort();
                throw new OperationFailedException(e);
            }
		}
	}
}
