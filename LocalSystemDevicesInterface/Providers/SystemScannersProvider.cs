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

        protected abstract IEnumerable<string> GetScannerNames();
    }
}
