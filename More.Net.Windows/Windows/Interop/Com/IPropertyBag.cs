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
    [Guid("55272A00-42CB-11CE-8135-00AA004BB851")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IPropertyBag
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pszPropName"></param>
        /// <param name="pVar"></param>
        /// <param name="pErrorLog"></param>
        /// <returns></returns>
        [PreserveSig]
        HResult Read(
            [In, MarshalAs(UnmanagedType.LPWStr)] string pszPropName,
            [Out, MarshalAs(UnmanagedType.Struct)] out object pVar,
            [In] IErrorLog pErrorLog);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pszPropName"></param>
        /// <param name="pVar"></param>
        /// <returns></returns>
        [PreserveSig]
        HResult Write(
            [In, MarshalAs(UnmanagedType.LPWStr)] string pszPropName,
            [In, MarshalAs(UnmanagedType.Struct)] ref object pVar);
    }
}
