using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More.Net.Windows.Interop.Com
{
    /// <summary>
    /// 
    /// </summary>
    public static class IPropertyBagExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyBag"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        public static String GetValue(
            this IPropertyBag propertyBag, 
            String propertyName)
        {
            if (propertyBag == null)
                throw new ArgumentNullException("propertyBag");

            Object val;
            propertyBag
                .Read(propertyName, out val, null)
                .ThrowOnError();
            return val as String;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyBag"></param>
        /// <param name="propertyName"></param>
        /// <param name="value"></param>
        public static void SetValue(
            this IPropertyBag propertyBag, 
            String propertyName, 
            String value)
        {
            if (propertyBag == null)
                throw new ArgumentNullException("propertyBag");

            Object val = value;
            propertyBag
                .Write(propertyName, ref val)
                .ThrowOnError();
        }
    }
}
