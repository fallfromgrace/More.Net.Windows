using System;
using System.Runtime.InteropServices;

namespace EZMetrology.Windows.Interop.Com
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct StgM
    {
        public Boolean Read
        {
            get { return (stgm & 0x00000001) == 0x00000000 || (stgm & 0x00000002) == 0x00000002; }
        }

        public Boolean Write
        {
            get { return (stgm & 0x00000001) == 0x00000001 || (stgm & 0x00000002) == 0x00000002; }
        }



        private readonly UInt32 stgm;
    }
}
