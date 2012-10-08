using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharp_Tac_Toe
{
    [Serializable()]
    class InvalidMoveException : System.Exception
    {
        public InvalidMoveException() : base() { }
        public InvalidMoveException(string message) : base(message) { }
        public InvalidMoveException(string message, System.Exception inner) : base(message, inner) { }

        // A constructor is needed for serialization when an 
        // exception propagates from a remoting server to the client.  
        protected InvalidMoveException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) { }
    }
}
