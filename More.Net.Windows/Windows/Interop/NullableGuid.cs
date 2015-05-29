using System;
using System.Runtime.InteropServices;

namespace EZMetrology.Windows.Interop
{
    /// <summary>
    /// A boxed guid class.
    /// </summary>
    /// <remarks>
    /// Required for COM interop because for some reason it does not support nullable types nor 
    /// fully qualified generics, so this class provides the ability to pass null as a parameter 
    /// for Guid without the compiler or runtime complaining.
    /// </remarks>
    [StructLayout(LayoutKind.Explicit)]
    public class NullableGuid
    {
        [FieldOffset(0)]
        private Guid guid;

        public static readonly NullableGuid Empty = Guid.Empty;

        /// <summary>
        /// 
        /// </summary>
        public NullableGuid()
        {
            this.guid = Guid.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="g"></param>
        public NullableGuid(String g)
        {
            this.guid = new Guid(g);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="g"></param>
        public NullableGuid(Guid g)
        {
            this.guid = g;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.guid.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        public string ToString(string format)
        {
            return this.guid.ToString(format);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return this.guid.GetHashCode();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="g"></param>
        /// <returns></returns>
        public static implicit operator Guid(NullableGuid g)
        {
            return g.guid;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="g"></param>
        /// <returns></returns>
        public static implicit operator NullableGuid(Guid g)
        {
            return new NullableGuid(g);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Guid ToGuid()
        {
            return this.guid;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="g"></param>
        /// <returns></returns>
        public static NullableGuid FromGuid(Guid g)
        {
            return new NullableGuid(g);
        }
    }
}
