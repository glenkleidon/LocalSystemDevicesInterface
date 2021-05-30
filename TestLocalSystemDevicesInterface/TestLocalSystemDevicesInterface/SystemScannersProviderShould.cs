using LocalSystemDevicesInterface;
using LocalSystemDevicesInterface.Exceptions;
using LocalSystemDevicesInterface.Providers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TestLocalSystemDevicesInterface
{
    public class SystemScannersProviderShould
    {
        private readonly string DefaultScanner = "Default scanner";
        private readonly string UnknownScanner = "Unknown scanner";

        private ISystemScannersProvider sut;
        public SystemScannersProviderShould()
        {
            sut = new SystemScannersProviderWin(DefaultScanner, UnknownScanner);
        }

        [Fact]
        public void InitializeWithoutError()
        {
            Assert.NotNull(sut);
        }
        [Fact]
        public void ListSystemScanners()
        {
            var printerNames = sut.ScannerNames;
            Assert.NotNull(sut.ScannerNames);
            foreach (var p in sut.ScannerNames)
            {
                Console.WriteLine(p);
            }
        }
        [Fact]
        public void ThrowUnknownForUnknownScanner()
        {
            Assert.Throws<UnknownLocalSystemScannerException>(() => sut.Capabilities(UnknownScanner));
        }
        [Fact]
        public void ReturnCapabilties()
        {
            var capabilities = sut.Capabilities(DefaultScanner);
            Assert.Equal(DefaultScanner, capabilities.Name);
            Assert.Empty(capabilities.Properties);
        }
    }
}
