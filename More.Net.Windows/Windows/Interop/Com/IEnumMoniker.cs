using System;
using System.Runtime.InteropServices;
using System.Security;

namespace EZMetrology.Windows.Interop.Com
{
    /// <summary>
    /// Manages the definition of the IEnumMoniker interface.
    /// </summary>
    [ComImport]
    [SuppressUnmanagedCodeSecurity]
    [Guid("00000102-0000-0000-C000-000000000046")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IEnumMoniker
    {
        /// <summary>
        /// Does not work because I have no fucking clue.
        /// </summary>
        /// <param name="celt"></param>
        /// <param name="rgelt"></param>
        /// <param name="pceltFetched"></param>
        /// <returns></returns>
        [PreserveSig]
        HResult Next(
            [In] UInt32 celt,
            [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] IMoniker[] rgelt,
            [Out] out UInt32 pceltFetched);

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
        [PreserveSig]
        HResult Reset();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ppenum"></param>
        [PreserveSig]
        HResult Clone(
            [Out] out IEnumMoniker ppenum);
    }
}
