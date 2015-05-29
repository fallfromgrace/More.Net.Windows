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
    public enum DuplicateOptions : uint
    {
        /// <summary>
        /// Closes the source handle. This occurs regardless of any error status returned.
        /// </summary>
        CloseSource = (0x00000001),

        /// <summary>
        /// Ignores the dwDesiredAccess parameter. The duplicate handle has the same access as the 
        /// source handle.
        /// </summary>
        SameAccess = (0x00000002)
    }
}
