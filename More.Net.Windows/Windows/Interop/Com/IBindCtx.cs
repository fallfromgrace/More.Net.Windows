using System;
using System.Runtime.InteropServices;
using System.Security;

namespace EZMetrology.Windows.Interop.Com
{
    /// <summary>
    /// Provides access to a bind context, which is an object that stores information about a 
    /// particular moniker binding operation.
    /// </summary>
    [ComImport]
    [SuppressUnmanagedCodeSecurity]
    [Guid("0000000e-0000-0000-C000-000000000046")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IBindCtx
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="punk"></param>
        HResult RegisterObjectBound(
            [In] Object punk);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="punk"></param>
        HResult RevokeObjectBound(
            [In] Object punk);

        /// <summary>
        /// 
        /// </summary>
        HResult ReleaseBoundObjects();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pbindopts"></param>
        HResult SetBindOptions(
            [In] ref BindOpts pbindopts);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pbindopts"></param>
        HResult GetBindOptions(
            [In, Out] ref BindOpts pbindopts);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pprot"></param>
        HResult GetRunningObjectTable(
            [Out] out IRunningObjectTable pprot);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pszKey"></param>
        /// <param name="punk"></param>
        HResult RegisterObjectParam(
            [In, MarshalAs(UnmanagedType.LPStr)] String pszKey,
            [In] Object punk);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pszKey"></param>
        /// <param name="ppunk"></param>
        HResult GetObjectParam(
            [In, MarshalAs(UnmanagedType.LPStr)] String pszKey,
            [Out] out Object ppunk);

        /// <summary>
        /// Enumerates the strings that are the keys of the internally maintained table of 
        /// contextual object parameters.
        /// </summary>
        /// <param name="ppenum">
        /// When this method returns, contains a reference to the object parameter enumerator.
        /// This parameter is passed uninitialized.
        /// </param>
        /// <returns></returns>
        HResult EnumObjectParam(
            [Out] out IEnumString ppenum);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pszKey"></param>
        /// <returns></returns>
        HResult RevokeObjectParam(
            [In, MarshalAs(UnmanagedType.LPStr)] String pszKey);
    }
}