using System;
using System.Collections.Generic;
using System.Text;

namespace LocalSystemDevicesInterface
{
    public static class Types
    {
        public enum OperatingSystemClass { Unknown, Windows, OSX, Linux, Other}
        public enum ScannerDocumentHandling { Unknown, 
            Flatbed, ADF, Transparency, AutoDectectSource,
            Duplex, AdvancedDuplex, InternalStorage,
            DetectsFlatbedLoaded, DetectsADFLoaded, ADFDetectBeforeScan,
              DetectsTransparencyLoaded, TransparencyDetectWhenReady, 
              DetectsDocsInInternalStorage
        }
    }
}
