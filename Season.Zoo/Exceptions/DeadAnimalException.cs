using System;
using System.Runtime.Serialization;

namespace Season.Zoo.Exceptions
{
    public class DeadAnimalException : Exception
    {
        public DeadAnimalException()
        {
        }

        public DeadAnimalException(string message) 
            : base(message)
        {
        }

        public DeadAnimalException(string message, Exception innerException) 
            : base(message, innerException)
        {
        }

        protected DeadAnimalException(SerializationInfo info, StreamingContext context) 
            : base(info, context)
        {
        }
    }
}