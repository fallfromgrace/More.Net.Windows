namespace More.Net.Windows.Interop.Com
{
    /// <summary>
    /// 
    /// </summary>
    public static class ComExtensions
    {
        /// <summary>
        /// Stores the COM object in a disposable object.
        /// </summary>
        /// <typeparam name="TComObject"></typeparam>
        /// <param name="comObject"></param>
        /// <returns></returns>
        public static IComDisposable<TComObject> AsComDisposable<TComObject>(
            this TComObject comObject)
            where TComObject : class
        {
            return new ComDisposable<TComObject>(comObject);
        }
    }
}
