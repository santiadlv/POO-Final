using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_P3.Clases
{
    class LengthException : Exception
    {
        public LengthException() : base() { }
        public LengthException(string data) : base (data){ }
    }
}
