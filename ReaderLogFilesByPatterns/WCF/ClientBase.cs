namespace ReaderLogFilesByPatterns.WCF
{
    using System;

    public abstract class ClientBase<TChannel>
    {
        protected TChannel Channel { get; }

        public void Abort()
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        protected virtual TChannel CreateChannel()
        {
            return default;
        }

        protected void InvokeAsync(
            System.ServiceModel.ClientBase<TChannel>.BeginOperationDelegate beginOperationDelegate,
            object[] inValues,
            System.ServiceModel.ClientBase<TChannel>.EndOperationDelegate endOperationDelegate,
            System.Threading.SendOrPostCallback operationCompletedCallback,
            object userState)
        {
            throw new NotImplementedException();
        }
    }
}

namespace System.ServiceModel
{
    public class ClientBase<T>
    {
        public delegate void BeginOperationDelegate();

        public delegate void EndOperationDelegate();
    }
}