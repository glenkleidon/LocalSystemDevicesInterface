using System.Collections.Generic;

namespace LocalSystemDevicesInterface
{
    public interface ISystemPrintersProvider
    {
        IEnumerable<string> PrinterNames { get;  }
    }
}