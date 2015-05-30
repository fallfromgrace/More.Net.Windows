using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace More.Net.Windows.Interop
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct HResult : IComparable, IComparable<HResult>, IEquatable<HResult>
    {
        #region Public Properties

        /// <summary>
        /// 
        /// </summary>
        public Boolean Succeeded
        {
            get { return value >= 0; }
        }

        /// <summary>
        /// 
        /// </summary>
        public Boolean Failed
        {
            get { return value < 0; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        private HResult(Int32 value)
        {
            this.value = value;
        }

        #endregion

        #region IComparable

        public Int32 CompareTo(Object obj)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IComparable<HResult>

        public Int32 CompareTo(HResult other)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IEquatable<HResult>

        public Boolean Equals(HResult other)
        {
            return value == other.value;
        }

        #endregion

        #region Overrides

        public override Boolean Equals(Object obj)
        {
            return Equals((HResult)obj);
        }

        public override Int32 GetHashCode()
        {
            return value;
        }

        public override String ToString()
        {
            if (this.Succeeded == true)
                return String.Format("HRESULT: 0x{0:X8}", this.value);
            else
                return String.Format("HRESULT: 0x{0:X8} {1}", this.value, this.GetException().Message);
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// 
        /// </summary>
        public void ThrowOnError()
        {
            Exception ex = this.GetException();
            if (ex != null)
                throw ex;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Exception GetException()
        {
            return Marshal.GetExceptionForHR(this);
        }

        #endregion

        #region Operators

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hr"></param>
        /// <returns></returns>
        public static implicit operator Int32(HResult hr)
        {
            return hr.value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static implicit operator HResult(Int32 value)
        {
            return new HResult(value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Boolean operator ==(HResult left, HResult right)
        {
            return left.Equals(right) == true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Boolean operator !=(HResult left, HResult right)
        {
            return left.Equals(right) == false;
        }

        #endregion

        #region Results

        /// <summary>
        /// Success 
        /// </summary>
        public static readonly HResult Ok = unchecked((Int32)0x00000000);

        /// <summary>
        /// Success 
        /// </summary>
        public static readonly HResult NoError = unchecked((Int32)0x00000000);

        /// <summary>
        /// Success false
        /// </summary>
        public static readonly HResult False = unchecked((Int32)0x00000001);

        ///<summary>
        /// Catastrophic failure
        ///</summary>
        public static readonly HResult Unexpected = unchecked((Int32)0x8000FFFF);

        /// <summary>
        /// Not implemented
        /// </summary>
        public static readonly HResult NotImplemented = unchecked((Int32)0x80004001);

        /// <summary>
        /// Ran out of memory
        /// </summary>
        public static readonly HResult OutOfMemory = unchecked((Int32)0x8007000E);

        /// <summary>
        /// One or more arguments are invalid
        /// </summary>
        public static readonly HResult InvalidArguments = unchecked((Int32)0x80070057);

        /// <summary>
        /// No such interface supported
        /// </summary>
        public static readonly HResult NoInterfaceSupported = unchecked((Int32)0x80004002);

        /// <summary>
        /// Invalid pointer
        /// </summary>
        public static readonly HResult InvalidPointer = unchecked((Int32)0x80004003);

        /// <summary>
        /// Invalid handle
        /// </summary>
        public static readonly HResult InvalidHandle = unchecked((Int32)0x80070006);

        /// <summary>
        /// Operation aborted
        /// </summary>
        public static readonly HResult Abort = unchecked((Int32)0x80004004);

        /// <summary>
        /// Unspecified error
        /// </summary>
        public static readonly HResult Fail = unchecked((Int32)0x80004005);

        /// <summary>
        /// General access denied error
        /// </summary>
        public static readonly HResult AccessDenied = unchecked((Int32)0x80070005);

        /// <summary>
        /// The data necessary to complete this operation is not yet available.
        /// </summary>
        public static readonly HResult Pending = unchecked((Int32)0x8000000A);

        #endregion

        #region Private Fields

        private readonly Int32 value;

        #endregion
    }
}
