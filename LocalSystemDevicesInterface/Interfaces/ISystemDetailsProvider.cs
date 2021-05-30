using static LocalSystemDevicesInterface.Types;

namespace LocalSystemDevicesInterface
{
    public interface ISystemDetailsProvider
    {
        ILocalSystemComputerNames ComputerNames { get; }
        OperatingSystemClass OperatingSystem { get; }
        string OperatingSystemDescription { get;  }
    }
}