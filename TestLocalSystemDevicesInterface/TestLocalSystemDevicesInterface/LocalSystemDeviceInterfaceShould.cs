using System;
using Xunit;
using LocalSystemDevicesInterface;
using Moq;
using LocalSystemDevicesInterface.Providers;
using System.Collections.Generic;
using System.Linq;
using LocalSystemDevicesInterface.DataTypes;

namespace TestLocalSystemDevicesInterface
{
    public class LocalSystemDeviceInterfaceShould
    {
        private const string testFQDN = "Test.computer.Name";
        private const string testMachineName = "Test.computer.Name";
        private const string testOS = "Test operating system.";

        private ILocalSystemDeviceInterface sut;

        public LocalSystemDeviceInterfaceShould()
        {
            var mockSystem = new Mock<ISystemDetailsProvider>();
            mockSystem
                .Setup(x => x.ComputerNames)
                .Returns(new LocalSystemComputerNames()
                {
                    FQDN = testFQDN,
                    MachineName = testMachineName
                });
            mockSystem
                .Setup(x => x.OperatingSystemDescription)
                .Returns(testOS);



            var mockScanners = new Mock<ISystemScannersProvider>();
            mockScanners
                .Setup(x => x.ScannerNames)
                .Returns(new List<string>()
                { 
                    "scanner1", 
                    "scanner2"
                });
            var mockPrinters = new Mock<ISystemPrintersProvider>();
            mockPrinters
                .Setup(x => x.PrinterNames)
                .Returns(new List<string>()
                {
                    "printer1",
                    "printer2"
                });

            sut = new LocalSystemDeviceInterface(mockSystem.Object, mockScanners.Object,
                 mockPrinters.Object);
        }

        [Fact]
        public void InitializeWithoutError()
        {
            Assert.NotNull(sut);
        }
        [Fact]
        public void ReturnSystemNames()
        {
            Assert.Equal(testFQDN, sut.SystemNames.FQDN);
            Assert.Equal(testMachineName, sut.SystemNames.MachineName);
        }
        [Fact]
        public void ReturnScannerNames()
        {
            Assert.Equal(2, sut.ScannerNames.Count());
            Assert.Equal("scanner1", sut.ScannerNames.FirstOrDefault());
            Assert.Equal("scanner2", sut.ScannerNames.Skip(1).FirstOrDefault());
        }
        [Fact]
        public void ReturnPrinterNames()
        {
            Assert.Equal(2, sut.PrinterNames.Count());
            Assert.Equal("printer1", sut.PrinterNames.FirstOrDefault());
            Assert.Equal("printer2", sut.PrinterNames.Skip(1).FirstOrDefault());
        }
        [Fact]
        public void ReturnsOSAndDescription()
        {
            Assert.Equal(Types.OperatingSystemClass.Unknown, sut.OperatingSystem);
            Assert.Equal(testOS, sut.OperatingSystemDescription);
        }
    }
}
