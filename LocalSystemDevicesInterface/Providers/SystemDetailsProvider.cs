using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using static LocalSystemDevicesInterface.Types;

namespace LocalSystemDevicesInterface.Providers
{
    class SystemDetailsProvider : ISystemDetailsProvider
    {
        public SystemDetailsProvider()
        {
        }

        public ILocalSystemComputerNames ComputerNames => throw new NotImplementedException();

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
