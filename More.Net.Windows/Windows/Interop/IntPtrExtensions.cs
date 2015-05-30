using System;
using System.Runtime.InteropServices;

namespace More.Net.Windows.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public static class IntPtrExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TStruct"></typeparam>
        /// <param name="ptr"></param>
        /// <returns></returns>
        public static TStruct ToStruct<TStruct>(this IntPtr ptr)
        {
            return (TStruct)Marshal.PtrToStructure(ptr, typeof(TStruct));
        }
    }
}
