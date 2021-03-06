using LocalSystemDevicesInterface.Scanners;
using System.Collections.Generic;

namespace LocalSystemDevicesInterface
{
    public interface ISystemScannersProvider
    {
        IEnumerable<string> ScannerNames { get; }
        ISystemScannerCapabilities Capabilities(string scannerName); 
    }
}