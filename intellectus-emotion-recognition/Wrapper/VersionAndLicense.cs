using EmotionRecognition.Import;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EmotionRecognition.Wrapper
{
    public static class VersionAndLicense
    {
        public static string GetVersionAndLicenseString()
        {
            return Marshal.PtrToStringAnsi(VokaturiDDLImport.Vokaturi_versionAndLicense());
        }
    }
}
