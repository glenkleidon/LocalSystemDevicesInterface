using System;
using System.Collections.Generic;
using System.Text;

namespace LocalSystemDevicesInterface.Exceptions
{
    public class UnknownLocalSystemDeviceException: Exception
    {
        public UnknownLocalSystemDeviceException()
        {
        }
        public UnknownLocalSystemDeviceException(string message) : base(message)
        {
        }
        public UnknownLocalSystemDeviceException(string message, Exception inner): base(message, inner)
        {
        }
    }
}
