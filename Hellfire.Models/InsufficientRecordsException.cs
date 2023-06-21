using System;

namespace HellfireStore
{
    class InsufficientRecordsException : Exception
    {
        public InsufficientRecordsException() { }
        public InsufficientRecordsException(string message) : base(message) { }
        public InsufficientRecordsException(string message,  Exception innerException) : base(message, innerException) { }
    }
}
