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
    public enum CreationDisposition : uint
    {
        /// <summary>
        /// 
        /// </summary>
        New = 1,

        /// <summary>
        /// 
        /// </summary>
        CreateAlways = 2,

        /// <summary>
        /// 
        /// </summary>
        OpenExisting = 3,

        /// <summary>
        /// 
        /// </summary>
        OpenAlways = 4,

        /// <summary>
        /// 
        /// </summary>
        TruncateExisting = 5,
    }
}
