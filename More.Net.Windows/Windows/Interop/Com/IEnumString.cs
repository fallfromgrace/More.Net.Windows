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
    [Guid("00000101-0000-0000-C000-000000000046")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IEnumString
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="celt"></param>
        /// <param name="rgelt"></param>
        /// <param name="pceltFetched"></param>
        /// <returns></returns>
        [PreserveSig]
        HResult Next(
            [In] Int32 celt,
            [Out, MarshalAs(
                UnmanagedType.LPArray,
                ArraySubType = UnmanagedType.LPStr,
                SizeParamIndex = 0)] String[] rgelt,
            [Out] out Int32 pceltFetched);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="celt"></param>
        /// <returns></returns>
        [PreserveSig]
        HResult Skip(
            [In] UInt32 celt);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [PreserveSig]
        HResult Reset();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ppenum"></param>
        [PreserveSig]
        HResult Clone(
            [Out] out IEnumString ppenum);
    }
}
