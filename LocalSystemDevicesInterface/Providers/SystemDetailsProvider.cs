using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using static LocalSystemDevicesInterface.Types;

namespace LocalSystemDevicesInterface.Providers
{
    public class SystemDetailsProvider : ISystemDetailsProvider
    {
        public SystemDetailsProvider()
        {
        }

        protected virtual string GetMachineName()
        {
            return System.Environment.MachineName;
        }

        public ILocalSystemComputerNames ComputerNames
        {
            get 
            {
                return new LocalSystemComputerNames()
                {
                    MachineName = GetMachineName(),
                    FQDN = GetFQDN()
                };
            }
        }

        private string GetFQDN()
        {
            return System.Net.Dns.GetHostEntry("").HostName;
        }

        public OperatingSystemClass OperatingSystem
        {
            get
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                    return OperatingSystemClass.Windows;
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                    return OperatingSystemClass.OSX;
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                    return OperatingSystemClass.Linux;
                else return OperatingSystemClass.Unknown;
            }
        }

        public string OperatingSystemDescription => RuntimeInformation.OSDescription;
    }
}
