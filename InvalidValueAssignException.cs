using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASE_Shape_Programming_language
{
    class InvalidValueAssignException : Exception
    {
        public InvalidValueAssignException() : base("Invalid command given.") { }
       
        public InvalidValueAssignException(string message) : base(message) { }
       
        public InvalidValueAssignException(string message, System.Exception inner) : base(message, inner) { }
        
        protected InvalidValueAssignException(System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
