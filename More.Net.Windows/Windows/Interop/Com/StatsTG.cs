using System;
using System.Runtime.InteropServices;

namespace EZMetrology.Windows.Interop.Com
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct StatsTG
    {
        /// <summary>
        /// 
        /// </summary>
        [MarshalAs(UnmanagedType.LPStr)]
        public String pwcsName;

        /// <summary>
        /// 
        /// </summary>
        public StgTY type;
        
        /// <summary>
        /// 
        /// </summary>
        public UInt64 cbSize;

        /// <summary>
        /// 
        /// </summary>
        public FileTime mtime;

        /// <summary>
        /// 
        /// </summary>
        public FileTime ctime;

        /// <summary>
        /// 
        /// </summary>
        public FileTime atime;

        /// <summary>
        /// 
        /// </summary>
        public StatFlag grfMode;

        /// <summary>
        /// 
        /// </summary>
        public LockType grfLocksSupported;

        /// <summary>
        /// 
        /// </summary>
        public Guid clsid;

        /// <summary>
        /// 
        /// </summary>
        public Int32 grfStateBits;

        /// <summary>
        /// 
        /// </summary>
        public Int32 reserved;
    }
}
