using System;
using System.Collections.Generic;
using System.Text;
using LocalSystemDevicesInterface.Providers;
using DNTScanner.Core;
using System.Linq;
using LocalSystemDevicesInterface.Scanners;
using LocalSystemDevicesInterface.DataTypes;
using LocalSystemDevicesInterface.Exceptions;
using LocalSystemDevicesInterface;

namespace RemoteSystemAgent.CustomProviders
{
    class SystemScannersProviderDNT : SystemScannersProvider
    {
        protected override IEnumerable<string> GetScannerNames()
        {
            return SystemDevices.GetScannerDevices().Select(s => s.Name);
        }
        public override ISystemScannerCapabilities Capabilities(string scannerName)
        {
            var defaultScanner = string.IsNullOrWhiteSpace(scannerName);
            var scanner = SystemDevices.GetScannerDevices()
                .Where(s => (defaultScanner || 
                  s.Name.Equals(scannerName, StringComparison.InvariantCultureIgnoreCase)))
                .FirstOrDefault();
            if (scanner == null) throw new UnknownLocalSystemScannerException(
                $"Scanner '{scannerName}' is not available.");
            
            var capabilities = new SystemScannerCapabilities(scannerName)
            {
                Resolutions = scanner.SupportedResolutions,
                Properties = scanner.ScannerDeviceSettings,
                DocumentHandling = GetHandlingCapabilities(scanner)
            };
            return capabilities;
        }

        private IList<Types.ScannerDocumentHandling> GetHandlingCapabilities(ScannerSettings scanner)
        {
            var handling = new List<Types.ScannerDocumentHandling>();
            if (scanner.IsAutomaticDocumentFeeder) handling.Add(Types.ScannerDocumentHandling.ADF);
            if (scanner.IsFlatbed) handling.Add(Types.ScannerDocumentHandling.Flatbed);
            if (scanner.IsDuplex) handling.Add(Types.ScannerDocumentHandling.Duplex);
            return handling;
        }
    }
}
