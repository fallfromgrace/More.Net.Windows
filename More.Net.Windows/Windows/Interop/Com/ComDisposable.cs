using System;
using System.Runtime.InteropServices;

namespace EZMetrology.Windows.Interop.Com
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TComObject"></typeparam>
    internal sealed class ComDisposable<TComObject> : IComDisposable<TComObject>
        where TComObject : class
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="comObject"></param>
        public ComDisposable(TComObject comObject)
        {
            if (Marshal.IsComObject(comObject) == false)
                throw new ArgumentException("comObject", "comObject is not a COM object");
            this.comObject = comObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public TComObject ComObject
        {
            get { return this.comObject; }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            Marshal.ReleaseComObject(comObject);
        }

        private readonly TComObject comObject;
    }
}
