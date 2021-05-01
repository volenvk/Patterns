using System;
using ReaderLogFilesByPatterns.Interfaces;

namespace ReaderLogFilesByPatterns.Decorator
{
    public static class LogSaverFactory
    {
		public static ILogSavers CreateLogSaver() => 
            new ThrottlingLogSaverDecorator(
                    new TraceLogSaverDecorator(
                        new ElasticsearchLogSaver()
                        ));
	}
}
