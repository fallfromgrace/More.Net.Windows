using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZMetrology.Windows.Interop.Com
{
    /// <summary>
    /// 
    /// </summary>
    public static class IMonikerExtensions
    {
        /// <summary>
        /// Retrieves the specified storage interface of the underlying IMoniker.  The interface 
        /// must be released after use.
        /// </summary>
        /// <typeparam name="TStorage"></typeparam>
        /// <param name="moniker"></param>
        /// <returns></returns>
        /// <exception cref="System.Runtime.InteropServices.ComException"></exception>
        /// <exception cref="System.NotSupportedException"></exception>
        public static TStorage BindToStorage<TStorage>(this IMoniker moniker)
            where TStorage : class
        {
            Object storage;
            moniker
                .BindToStorage(null, null, typeof(TStorage).GUID, out storage)
                .ThrowOnError();
            if (storage == null)
                throw new NotSupportedException(String.Format("Object type {0} is not supported.", typeof(TStorage).Name));
            return (TStorage)storage;
        }

        /// <summary>
        /// Retrieves the specified object interface of the underlying IMoniker.  The interface 
        /// must be released after use.
        /// </summary>
        /// <typeparam name="TObject"></typeparam>
        /// <param name="moniker"></param>
        /// <returns></returns>
        /// <exception cref="System.Runtime.InteropServices.ComException"></exception>
        /// <exception cref="System.NotSupportedException"></exception>
        public static TObject BindToObject<TObject>(this IMoniker moniker)
            where TObject : class
        {
            Object obj;
            moniker
                .BindToObject(null, null, typeof(TObject).GUID, out obj)
                .ThrowOnError();
            if (obj == null)
                throw new NotSupportedException();
            return (TObject)obj;
        }
    }
}
