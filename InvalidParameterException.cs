using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASE_Shape_Programming_language
{
    public class InvalidParameterException : System.Exception
    {
        public InvalidParameterException() : base("Invalid Parameter given for the command") { }
        public InvalidParameterException(string message) : base(message) { }
        public InvalidParameterException(string message, System.Exception inner) : base(message, inner) { }

        protected InvalidParameterException(System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
