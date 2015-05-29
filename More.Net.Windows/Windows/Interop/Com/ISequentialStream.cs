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
    [Guid("0C733A30-2A1C-11CE-ADE5-00AA0044773D")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ISequentialStream
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pv"></param>
        /// <param name="cb"></param>
        /// <param name="pcbRead"></param>
        /// <returns></returns>
        HResult Read(
            [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] Byte[] pv,
            [In] UInt32 cb, 
            [Out] out UInt32 pcbRead);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pv"></param>
        /// <param name="cb"></param>
        /// <param name="pcbWritten"></param>
        /// <returns></returns>
        HResult Write(
            [In, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] Byte[] pv,
            [In] UInt32 cb,
            [Out] out UInt32 pcbWritten);
    }
}
