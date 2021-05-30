using System;
using System.Collections.Generic;
using System.Text;
using static LocalSystemDevicesInterface.Types;

namespace LocalSystemDevicesInterface
{
    public class LocalSystemDeviceInterface : ILocalSystemDeviceInterface
    {
        private readonly ISystemDetailsProvider systemDetails;

        private readonly ISystemScannersProvider scanners;

        private readonly ISystemPrintersProvider printers;

        public LocalSystemDeviceInterface(ISystemDetailsProvider systemDetails, 
            ISystemScannersProvider scanners,
            ISystemPrintersProvider printers) 
        {
            this.systemDetails = systemDetails;
            this.scanners = scanners;
            this.printers = printers;
        }

        public ILocalSystemComputerNames SystemNames => systemDetails.ComputerNames;

        public IEnumerable<string> ScannerNames => scanners.ScannerNames;

        public IEnumerable<string> PrinterNames => printers.PrinterNames;

        public string OperatingSystemDescription => systemDetails.OperatingSystemDescription;

        public OperatingSystemClass OperatingSystem => systemDetails.OperatingSystem;
    }
}
