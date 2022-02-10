using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_Exceptions_Lesson13
{

    [Serializable]
    public class ArgumentDoorsException : ApplicationException
    {
        public Car Car { get; set; }
        public ArgumentDoorsException() { }
        public ArgumentDoorsException(string message) : base(message) { }
        public ArgumentDoorsException(string message, Exception inner) : base(message, inner) { }
        protected ArgumentDoorsException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

        public ArgumentDoorsException(string message, Car car)
        {
            Car = car;
        }
    }
}
