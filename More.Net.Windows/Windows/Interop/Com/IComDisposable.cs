using System;

namespace More.Net.Windows.Interop.Com
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TComObject"></typeparam>
    public interface IComDisposable<TComObject> : IDisposable
        where TComObject : class
    {
        /// <summary>
        /// 
        /// </summary>
        TComObject ComObject { get; }
    }
}
