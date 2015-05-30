using System;
using System.Runtime.InteropServices;
using System.Security;
using EXCEPINFO = System.Runtime.InteropServices.ComTypes.EXCEPINFO;

namespace More.Net.Windows.Interop.Com
{
    /// <summary>
    /// 
    /// </summary>
    [ComImport]
    [SuppressUnmanagedCodeSecurity]
    [Guid("3127CA40-446E-11CE-8135-00AA004BB851")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IErrorLog
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pszPropName"></param>
        /// <param name="pExcepInfo"></param>
        /// <returns></returns>
        [PreserveSig]
        HResult AddError(
            [In, MarshalAs(UnmanagedType.LPWStr)] string pszPropName,
            [In] EXCEPINFO pExcepInfo);
    }
}
