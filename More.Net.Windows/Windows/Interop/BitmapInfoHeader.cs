using System;
using System.Runtime.InteropServices;

namespace EZMetrology.Windows.Interop
{
    /// <summary>
    /// From BITMAPINFOHEADER
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public class BitmapInfoHeader
    {
        public Int32 Size;
        public Int32 Width;
        public Int32 Height;
        public Int16 Planes;
        public Int16 BitCount;
        public Int32 Compression;
        public Int32 ImageSize;
        public Int32 XPelsPerMeter;
        public Int32 YPelsPerMeter;
        public Int32 ClrUsed;
        public Int32 ClrImportant;
    }
}
