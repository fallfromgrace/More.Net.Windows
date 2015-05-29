using System;
using System.Runtime.InteropServices;
using System.Security;

namespace EZMetrology.Windows.Interop.Com
{
    /// <summary>
    /// 
    /// </summary>
    [ComImport]
    [SuppressUnmanagedCodeSecurity]
    [Guid("B196B28B-BAB4-101A-B69C-00AA00341D07")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ISpecifyPropertyPages
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pPages"></param>
        /// <returns></returns>
        [PreserveSig]
        Int32 GetPages(out DsCAUUID pPages);
    }
}
