using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_Exceptions_Lesson13
{
    [Serializable]
    public class ArgumentColorException : ApplicationException
    {
        public ArgumentColorException() 
        {
        }
        public ArgumentColorException(string message) : base(message)
        { 
        }
        public ArgumentColorException(string message, Exception inner) : base(message, inner)
        {
        }
        protected ArgumentColorException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context) 
        {
        }
    }
}
