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
    [Guid("00000010-0000-0000-C000-000000000046")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IRunningObjectTable
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="grfFlags"></param>
        /// <param name="punkObject"></param>
        /// <param name="pmkObjectName"></param>
        /// <returns></returns>
        [PreserveSig]
        HResult Register(
            [In] RotFlags grfFlags,
            [In] Object punkObject,
            [In] IMoniker pmkObjectName,
            [Out] out Int32 pdwRegister);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dwRegister"></param>
        /// <returns></returns>
        [PreserveSig]
        HResult Revoke(
            Int32 dwRegister);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pmkObjectName"></param>
        /// <returns></returns>
        [PreserveSig]
        HResult IsRunning(
            [In] IMoniker pmkObjectName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pmkObjectName"></param>
        /// <param name="ppunkObject"></param>
        /// <returns></returns>
        [PreserveSig]
        HResult GetObject(
            [In] IMoniker pmkObjectName,
            [Out] out Object ppunkObject);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dwRegister"></param>
        /// <param name="pfiletime"></param>
        /// <returns></returns>
        [PreserveSig]
        HResult NoteChangeTime(
            [In] Int32 dwRegister,
            [In] ref FileTime pfiletime);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pmkObjectName"></param>
        /// <param name="pfiletime"></param>
        /// <returns></returns>
        [PreserveSig]
        HResult GetTimeOfLastChange(
            [In] IMoniker pmkObjectName,
            [Out] out FileTime pfiletime);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ppenumMoniker"></param>
        [PreserveSig]
        HResult EnumRunning(
            [Out] out IEnumMoniker ppenumMoniker);
    }
}
