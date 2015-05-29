using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZMetrology.Windows.Interop.Win32
{
    /// <summary>
    /// 
    /// </summary>
    [Flags]
    public enum GenericAccess : uint
    {
        /// <summary>
        /// 
        /// </summary>
        Read = 0x80000000,

        /// <summary>
        /// 
        /// </summary>
        Write = 0x40000000,

        /// <summary>
        /// 
        /// </summary>
        Execute = 0x20000000,
        
        /// <summary>
        /// 
        /// </summary>
        All = 0x10000000,
    }
}
