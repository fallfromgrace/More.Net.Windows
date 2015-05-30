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
    [Guid("0000000f-0000-0000-C000-000000000046")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMoniker : IPersistStream
    {
        #region IPersistStream

        #region IPersist

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
        new HResult IsDirty();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pStm"></param>
        /// <returns></returns>
        [PreserveSig]
        new HResult Load(
            [In] IStream pStm);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pStm"></param>
        /// <param name="fClearDirty"></param>
        /// <returns></returns>
        [PreserveSig]
        new HResult Save(
            [In] IStream pStm,
            [In, MarshalAs(UnmanagedType.Bool)] Boolean fClearDirty);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pcbSize"></param>
        /// <returns></returns>
        [PreserveSig]
        new HResult GetSizeMax(
            [Out] out Int64 pcbSize);

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pbc"></param>
        /// <param name="pmkToLeft"></param>
        /// <param name="riidResult"></param>
        /// <param name="ppvResult"></param>
        [PreserveSig]
        HResult BindToObject(
            [In] IBindCtx pbc,
            [In] IMoniker pmkToLeft,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid riidResult,
            [Out, MarshalAs(UnmanagedType.Interface)] out Object ppvResult);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pbc"></param>
        /// <param name="pmkToLeft"></param>
        /// <param name="riid"></param>
        /// <param name="ppvObj"></param>
        [PreserveSig]
        HResult BindToStorage(
            [In] IBindCtx pbc,
            [In] IMoniker pmkToLeft,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid riid,
            [Out, MarshalAs(UnmanagedType.Interface)] out Object ppvObj);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pbc"></param>
        /// <param name="dwReduceHowFar"></param>
        /// <param name="ppmkToLeft"></param>
        /// <param name="ppmkReduced"></param>
        [PreserveSig]
        HResult Reduce(
            [In] IBindCtx pbc,
            [In] MkrReduce dwReduceHowFar,
            [In, Out] ref IMoniker ppmkToLeft,
            [Out] out IMoniker ppmkReduced);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pmkRight"></param>
        /// <param name="fOnlyIfNotGeneric"></param>
        /// <param name="ppmkComposite"></param>
        [PreserveSig]
        HResult ComposeWith(
            [In] IMoniker pmkRight,
            [In, MarshalAs(UnmanagedType.Bool)] Boolean fOnlyIfNotGeneric,
            [Out] out IMoniker ppmkComposite);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fForward"></param>
        /// <param name="ppenumMoniker"></param>
        [PreserveSig]
        HResult Enum(
            [In, MarshalAs(UnmanagedType.Bool)] Boolean fForward,
            [Out] out IEnumMoniker ppenumMoniker);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pmkOtherMoniker"></param>
        /// <returns></returns>
        [PreserveSig]
        HResult IsEqual(
            [In] IMoniker pmkOtherMoniker);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pdwHash"></param>
        [PreserveSig]
        HResult Hash(
            [Out] out Int32 pdwHash);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pbc"></param>
        /// <param name="pmkToLeft"></param>
        /// <param name="pmkNewlyRunning"></param>
        /// <returns></returns>
        [PreserveSig]
        HResult IsRunning(
            [In] IBindCtx pbc,
            [In] IMoniker pmkToLeft,
            [In] IMoniker pmkNewlyRunning);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pbc"></param>
        /// <param name="pmkToLeft"></param>
        /// <param name="pFileTime"></param>
        [PreserveSig]
        HResult GetTimeOfLastChange(
            [In] IBindCtx pbc,
            [In] IMoniker pmkToLeft,
            [Out] out FileTime pFileTime);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ppmk"></param>
        [PreserveSig]
        HResult Inverse(
            [Out] out IMoniker ppmk);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pmkOther"></param>
        /// <param name="ppmkPrefix"></param>
        [PreserveSig]
        HResult CommonPrefixWith(
            [In] IMoniker pmkOther,
            [Out] out IMoniker ppmkPrefix);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pmkOther"></param>
        /// <param name="ppmkRelPath"></param>
        [PreserveSig]
        HResult RelativePathTo(
            [In] IMoniker pmkOther,
            [Out] out IMoniker ppmkRelPath);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pbc"></param>
        /// <param name="pmkToLeft"></param>
        /// <param name="ppszDisplayName"></param>
        [PreserveSig]
        HResult GetDisplayName(
            [In] IBindCtx pbc,
            [In] IMoniker pmkToLeft,
            [Out, MarshalAs(UnmanagedType.LPStr)] out String ppszDisplayName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pbc"></param>
        /// <param name="pmkToLeft"></param>
        /// <param name="pszDisplayName"></param>
        /// <param name="pchEaten"></param>
        /// <param name="ppmkOut"></param>
        [PreserveSig]
        HResult ParseDisplayName(
            [In] IBindCtx pbc,
            [In] IMoniker pmkToLeft,
            [In, MarshalAs(UnmanagedType.LPStr)] String pszDisplayName,
            [Out] out UInt32 pchEaten,
            [Out] out IMoniker ppmkOut);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pdwMksys"></param>
        /// <returns></returns>
        [PreserveSig]
        HResult IsSystemMoniker(
            [Out] out MkSys pdwMksys);
    }
}
