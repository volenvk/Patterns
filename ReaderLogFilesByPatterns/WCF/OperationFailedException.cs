namespace ReaderLogFilesByPatterns.WCF
{
    using System;

    public class OperationFailedException : Exception
    {
        public OperationFailedException(Exception exception)
        {
            throw exception;
        }
    }
}