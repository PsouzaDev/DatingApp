using System;
using System.Runtime.Serialization;

namespace DatingApp.API.Controllers
{
    [Serializable]
    internal class DBConException : Exception
    {
        public DBConException()
        {
        }

        public DBConException(string message) : base(message)
        {
        }

        public DBConException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DBConException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}