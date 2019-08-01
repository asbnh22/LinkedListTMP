using System;
using System.Linq;
using System.Runtime.Serialization;

namespace LinkedList
{
    [System.Serializable]
    class ListIsNotSortedException : ApplicationException
    {
        public ListIsNotSortedException() { }

        public ListIsNotSortedException(string message) : base(message) { }

        public ListIsNotSortedException(string message, Exception inner) : base(message, inner) { }

        protected ListIsNotSortedException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
