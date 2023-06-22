using System;

namespace HellfireStore.Exceptions
{
    class InsufficientRecordsException : Exception
    {
        public InsufficientRecordsException() { }
        public InsufficientRecordsException(string message) : base(message) { }
        public InsufficientRecordsException(string message,  Exception innerException) : base(message, innerException) { }
    }
}
