using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security;

namespace More.Net.Windows.Interop.Com
{
    /// <summary>
    /// 
    /// </summary>
    [ComImport]
    [SuppressUnmanagedCodeSecurity]
    [Guid("00000109-0000-0000-C000-000000000046")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IPersistStream : IPersist
    {
        #region IPersist Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pClassID"></param>
        /// <returns></returns>
        [PreserveSig]
        new HResult GetClassID(
            [Out] out Guid pClassID);

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [PreserveSig]
        HResult IsDirty();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pStm"></param>
        /// <returns></returns>
        [PreserveSig]
        HResult Load(
            [In] IStream pStm);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pStm"></param>
        /// <param name="fClearDirty"></param>
        /// <returns></returns>
        [PreserveSig]
        HResult Save(
            [In] IStream pStm,
            [In, MarshalAs(UnmanagedType.Bool)] Boolean fClearDirty);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pcbSize"></param>
        /// <returns></returns>
        [PreserveSig]
        HResult GetSizeMax(
            [Out] out Int64 pcbSize);
    }
}
