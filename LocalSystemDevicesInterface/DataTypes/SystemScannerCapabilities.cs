using LocalSystemDevicesInterface.Scanners;
using System;
using System.Collections.Generic;
using System.Text;

namespace LocalSystemDevicesInterface.DataTypes
{
    public class SystemScannerCapabilities : ISystemScannerCapabilities
    {
        public string Name { get ; set ; }
        public IDictionary<string, object> Properties { get; set; }

        public IList<int> Resolutions { get; set; }
  
        public IList<Types.ScannerDocumentHandling> DocumentHandling { get; set; }

        public SystemScannerCapabilities(string scannerName)
        {
            Name = scannerName;
        }
    }
}
