using System;
using System.Collections.Generic;
using System.Text;

namespace LocalSystemDevicesInterface.Providers
{
    public class LocalSystemComputerNames : ILocalSystemComputerNames
    {
        public string FQDN { get ; set; }
        public string MachineName { get ; set ; }
    }
}
