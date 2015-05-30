using System;
using System.Runtime.InteropServices;
using System.Security;

namespace More.Net.Windows.Interop.Com
{
    /// <summary>
    /// 
    /// </summary>
    [ComImport]
    [SuppressUnmanagedCodeSecurity]
    [Guid("0000010c-0000-0000-C000-000000000046")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IPersist
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pClassID"></param>
        /// <returns></returns>
        [PreserveSig]
        HResult GetClassID([Out] out Guid pClassID);
    }
}
