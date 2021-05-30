using LocalSystemDevicesInterface;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TestLocalSystemDevicesInterface
{
    public class SystemPrintersProviderShould
    {
        private ISystemPrintersProvider sut;
        public SystemPrintersProviderShould()
        {
            sut = new SystemPrintersProviderWin();
        }

        [Fact]
        public void InitializeWithoutError()
        {
            Assert.NotNull(sut);
        }
        [Fact]
        public void ListSystemPrinters()
        {
            var printerNames = sut.PrinterNames;
            Assert.NotNull(sut.PrinterNames);
            foreach (var p in sut.PrinterNames)
            {
                Console.WriteLine(p);
            }
        }
    }
}
