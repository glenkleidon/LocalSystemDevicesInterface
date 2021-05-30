using LocalSystemDevicesInterface;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Management;
using System.Linq;

namespace LocalSystemDevicesInterface
{
    public class SystemPrintersProvider : ISystemPrintersProvider
    {
        public IEnumerable<string> PrinterNames
        {
            get
            {
                var names = new List<string>();
                foreach (string name in PrinterSettings.InstalledPrinters)
                {
                    names.Add(name);
                }
                return names;
            }
        }
           
    }
}