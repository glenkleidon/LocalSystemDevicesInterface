using System;
using System.Collections.Generic;
using System.Text;

namespace LocalSystemDevicesInterface.Exceptions
{
    public class UnknownLocalSystemScannerException: Exception
    {
        public UnknownLocalSystemScannerException()
        {
        }
        public UnknownLocalSystemScannerException(string message) : base(message)
        {
        }
        public UnknownLocalSystemScannerException(string message, Exception inner): base(message, inner)
        {
        }
    }
}
