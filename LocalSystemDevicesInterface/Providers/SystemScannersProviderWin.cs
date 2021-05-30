using System;
using System.Collections.Generic;
using System.Text;

namespace LocalSystemDevicesInterface.Providers
{
    public class SystemScannersProviderWin : SystemScannersProvider
    {
        protected override IEnumerable<string> GetScannerNames()
        {
            return new List<string>(); 
        }
    }
}
