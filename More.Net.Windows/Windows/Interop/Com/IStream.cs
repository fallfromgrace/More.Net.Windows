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
    [Guid("0000000c-0000-0000-C000-000000000046")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IStream : ISequentialStream
    {
        #region ISequentialStream

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pv"></param>
        /// <param name="cb"></param>
        /// <param name="pcbRead"></param>
        /// <returns></returns>
        new HResult Read(
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
        new HResult Write(
            [In, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] Byte[] pv,
            [In] UInt32 cb,
            [Out] out UInt32 pcbWritten);

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dlibMove"></param>
        /// <param name="dwOrigin"></param>
        /// <param name="plibNewPosition"></param>
        [PreserveSig]
        HResult Seek(
            [In] Int64 dlibMove,
            [In] Int32 dwOrigin,
            [Out] out UInt64 plibNewPosition);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="libNewSize"></param>
        [PreserveSig]
        HResult SetSize(
            [In] UInt64 libNewSize);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pstm"></param>
        /// <param name="cb"></param>
        /// <param name="pcbRead"></param>
        /// <param name="pcbWritten"></param>
        [PreserveSig]
        HResult CopyTo(
            [In] IStream pstm,
            [In] Int64 cb,
            [Out] out Int64 pcbRead,
            [Out] out Int64 pcbWritten);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="grfCommitFlags"></param>
        /// <returns></returns>
        [PreserveSig]
        HResult Commit(
            [In] StgC grfCommitFlags);

        /// <summary>
        /// 
        /// </summary>
        [PreserveSig]
        HResult Revert();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="libOffset"></param>
        /// <param name="cb"></param>
        /// <param name="nt"></param>
        [PreserveSig]
        HResult LockRegion(
            [In] UInt64 libOffset,
            [In] UInt64 cb,
            [In] LockType dwLockType);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="libOffset"></param>
        /// <param name="cb"></param>
        /// <param name="dwLockType"></param>
        [PreserveSig]
        HResult UnlockRegion(
            [In] UInt64 libOffset,
            [In] UInt64 cb,
            [In] Int32 dwLockType);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pstatstg"></param>
        /// <param name="grfStatFlag"></param>
        [PreserveSig]
        HResult Stat(
            [Out] out StatsTG pstatstg,
            [In] Int32 grfStatFlag);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ppstm"></param>
        [PreserveSig]
        HResult Clone(
            [Out] out IStream ppstm);
    }
}
