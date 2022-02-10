using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_Exceptions_Lesson13
{
    internal class Class1Exception
    {
        public string Message { get; set; }
        public string StackTrace { get; set; }

        public Class1Exception()
        {

        }

        public Class1Exception(string message)
        {
            Message = message;
        }
    }
}
