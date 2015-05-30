using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More.Net.Windows.Interop.Win32
{
    /// <summary>
    /// 
    /// </summary>
    [Flags]
    public enum FileShare : uint
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0x00000000,

        /// <summary>
        /// 
        /// </summary>
        Read = 0x00000001,

        /// <summary>
        /// 
        /// </summary>
        Write = 0x00000002,

        /// <summary>
        /// 
        /// </summary>
        Delete = 0x00000004,
    }
}
