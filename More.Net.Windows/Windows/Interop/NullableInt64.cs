using System;
using System.Runtime.InteropServices;

namespace More.Net.Windows.Interop
{
    /// <summary>
    /// A boxed guid class.
    /// </summary>
    /// <remarks>
    /// Required for COM interop because for some reason it does not support nullable types nor 
    /// fully qualified generics, so this class provides the ability to pass null as a parameter 
    /// for Int64 without the compiler or runtime complaining.
    /// </remarks>
    [StructLayout(LayoutKind.Explicit)]
    public class NullableInt64
    {
        [FieldOffset(0)]
        private Int64 value;

        /// <summary>
        /// 
        /// </summary>
        public NullableInt64()
        {
            this.value = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="g"></param>
        public NullableInt64(Int64 value)
        {
            this.value = value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.value.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        public string ToString(string format)
        {
            return this.value.ToString(format);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return this.value.GetHashCode();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="g"></param>
        /// <returns></returns>
        public static implicit operator Int64(NullableInt64 g)
        {
            return g.value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="g"></param>
        /// <returns></returns>
        public static implicit operator NullableInt64(Int64 value)
        {
            return new NullableInt64(value);
        }
    }
}
