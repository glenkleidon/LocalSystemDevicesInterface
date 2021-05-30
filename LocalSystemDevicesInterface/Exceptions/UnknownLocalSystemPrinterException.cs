using System;
using System.Collections.Generic;
using System.Text;

namespace LocalSystemDevicesInterface.Exceptions
{
    public class UnknownLocalSystemPrinterException: Exception
    {
        public UnknownLocalSystemPrinterException()
        {
        }
        public UnknownLocalSystemPrinterException(string message) : base(message)
        {
        }
        public UnknownLocalSystemPrinterException(string message, Exception inner): base(message, inner)
        {
        }
    }
}
