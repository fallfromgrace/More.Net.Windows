using System;
using System.Runtime.InteropServices;

namespace EZMetrology.Windows.Interop.Com
{
    /// <summary>
    /// 
    /// </summary>
    [ComImport]
    [Guid("6d5140c1-7436-11ce-8034-00aa006009fa")]
    interface IServiceProvider
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="guidService"></param>
        /// <param name="riid"></param>
        /// <param name="ppvObject"></param>
        void QueryService(
            ref Guid guidService,
            ref Guid riid,
            [MarshalAs(UnmanagedType.Interface)] out Object ppvObject);
    }
}
