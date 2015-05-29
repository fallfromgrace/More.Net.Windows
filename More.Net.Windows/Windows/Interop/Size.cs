using System;
using System.Runtime.InteropServices;

namespace EZMetrology.Windows.Interop
{
    /// <summary>
    /// Specifies the width and height of a rectangle.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct Size
    {
        /// <summary>
        /// Specifies the rectangle's width. The units depend on which function uses this.
        /// </summary>
        public Int32 cx;

        /// <summary>
        /// Specifies the rectangle's height. The units depend on which function uses this.
        /// </summary>
        public Int32 cy;
    }
}
