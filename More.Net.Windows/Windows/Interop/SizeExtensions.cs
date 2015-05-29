using System;

namespace EZMetrology.Windows.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public static class SizeExtensions
    {
        /// <summary>
        /// Converts a Win32 Size struct to the EZMetrology library version.
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public static Size<Int32> ToSize(this Size size)
        {
            return new Size<Int32>(size.cx, size.cy);
        }
    }
}
