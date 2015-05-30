using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace More.Net.Windows.Interop.Win32
{
    /// <summary>
    /// MS VC++ Runtime.
    /// </summary>
    public static class Msvcrt
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dest"></param>
        /// <param name="src"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        [DllImport(
            "msvcrt.dll", 
            EntryPoint = "memcpy", 
            CallingConvention = CallingConvention.Cdecl, 
            SetLastError = false)]
        public static extern IntPtr MemCpy(IntPtr dest, IntPtr src, UIntPtr count);
    }
}
