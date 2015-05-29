using System;

namespace EZMetrology.Windows.Interop.Com
{
    /// <summary>
    /// 
    /// </summary>
    [Flags]
    public enum StgC
    {
        /// <summary>
        /// 
        /// </summary>
        Default = 0,

        /// <summary>
        /// 
        /// </summary>
        Overwrite = 1,

        /// <summary>
        /// 
        /// </summary>
        OnlyIfCurrent = 2,

        /// <summary>
        /// 
        /// </summary>
        DangerousCommitMerelyToDiskCache = 4,

        /// <summary>
        /// 
        /// </summary>
        Consolidate = 8
    }
}
