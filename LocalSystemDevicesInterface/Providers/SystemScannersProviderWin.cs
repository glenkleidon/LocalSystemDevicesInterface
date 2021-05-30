using LocalSystemDevicesInterface.DataTypes;
using LocalSystemDevicesInterface.Exceptions;
using LocalSystemDevicesInterface.Scanners;
using System;
using System.Collections.Generic;
using System.Text;

namespace LocalSystemDevicesInterface.Providers
{
    /// <summary>
    /// Base provide - Predominantly used for integration testing with DI when
    /// mocking is not sensible.  Normally you would inject a Custom provider
    /// suitable for the platform.
    /// </summary>
    public class SystemScannersProviderWin : SystemScannersProvider
    {
        public SystemScannersProviderWin()
        {
        }

        protected override IEnumerable<string> GetScannerNames()
        {
            return new List<string>(); 
        }

        public SystemScannersProviderWin(string defaultScanner, string unknownScanner="")
        {
            DefaultScanner = defaultScanner;
            this.unknownScanner = unknownScanner;

        }
        public string DefaultScanner { get; set; }

        private readonly string unknownScanner;

        public override ISystemScannerCapabilities Capabilities(string scannerName)
        {
            if (scannerName.Equals(unknownScanner, StringComparison.InvariantCultureIgnoreCase))
                throw new UnknownLocalSystemScannerException();

            return new SystemScannerCapabilities(scannerName)
            {
                Properties = new Dictionary<string, object>()
            };
        }
    }
}
