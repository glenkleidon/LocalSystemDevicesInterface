using System.Collections.Generic;
using static LocalSystemDevicesInterface.Types;

namespace LocalSystemDevicesInterface.Scanners
{
    public interface ISystemScannerCapabilities
    {
        string Name { get; }
        IDictionary<string, object> Properties { get; }
        IList<int> Resolutions { get; }
        IList<ScannerDocumentHandling> DocumentHandling { get; }
    }
}