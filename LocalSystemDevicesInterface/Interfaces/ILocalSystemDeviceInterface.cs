using System.Collections.Generic;
using static LocalSystemDevicesInterface.Types;

namespace LocalSystemDevicesInterface
{
    public interface ILocalSystemDeviceInterface
    {
        ILocalSystemComputerNames SystemNames { get; }
        IEnumerable<string> ScannerNames { get; }
        IEnumerable<string> PrinterNames { get; }
        string OperatingSystemDescription { get; }
        OperatingSystemClass OperatingSystem { get;  }
    }
}