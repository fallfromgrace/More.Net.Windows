using System;

namespace More.Net.Windows.Interop.Com
{
    /// <summary>
    /// 
    /// </summary>
    [Flags]
    public enum LockType
    {
        /// <summary>
        /// 
        /// </summary>
        Write = 1,

        /// <summary>
        /// 
        /// </summary>
        Exclusive = 2,

        /// <summary>
        /// 
        /// </summary>
        OnlyOnce = 4
    }
}
