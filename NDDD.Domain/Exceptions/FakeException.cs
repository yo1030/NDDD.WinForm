using System;

namespace NDDD.Domain.Exceptions
{
    public sealed class FakeException : ExceptionBase
    {
        public FakeException(string message, Exception ex)
            :base(message, ex)
        {
            
        }

        public override ExceptionKind Kind => ExceptionKind.Error;
    }
}
