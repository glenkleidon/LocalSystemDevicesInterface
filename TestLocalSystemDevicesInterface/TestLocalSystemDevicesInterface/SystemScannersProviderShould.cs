using LocalSystemDevicesInterface;
using LocalSystemDevicesInterface.Providers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TestLocalSystemDevicesInterface
{
    public class SystemScannersProviderShould
    {
        private ISystemScannersProvider sut;
        public SystemScannersProviderShould()
        {
            sut = new SystemScannersProviderWin();
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
    }
}
