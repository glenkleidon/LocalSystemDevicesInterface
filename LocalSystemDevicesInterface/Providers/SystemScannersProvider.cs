using LocalSystemDevicesInterface.Scanners;
using System;
using System.Collections.Generic;
using System.Text;

namespace LocalSystemDevicesInterface.Providers
{
    public abstract class SystemScannersProvider : ISystemScannersProvider
    {
        public IEnumerable<string> ScannerNames
        {
            get
            {
                return GetScannerNames();
            }
        }

        public abstract ISystemScannerCapabilities Capabilities(string scannerName);

        protected abstract IEnumerable<string> GetScannerNames();
    }
}
