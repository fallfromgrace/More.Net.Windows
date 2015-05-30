using System;
using System.Runtime.InteropServices;

namespace More.Net.Windows.Interop
{
    /// <summary>
    /// Rect is a managed representation of the Win32 RECT structure.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class Rect : IEquatable<Rect>
    {
        public Int32 left;
        public Int32 top;
        public Int32 right;
        public Int32 bottom;

        /// <summary>
        /// Empty contructor. Initialize all fields to 0
        /// </summary>
        public Rect()
        {
            this.left = 0;
            this.top = 0;
            this.right = 0;
            this.bottom = 0;
        }

        /// <summary>
        /// A parametred constructor. Initialize fields with given values.
        /// </summary>
        /// <param name="left">the left value</param>
        /// <param name="top">the top value</param>
        /// <param name="right">the right value</param>
        /// <param name="bottom">the bottom value</param>
        public Rect(Int32 left, Int32 top, Int32 right, Int32 bottom)
        {
            this.left = left;
            this.top = top;
            this.right = right;
            this.bottom = bottom;
        }

        /// <summary>
        /// Provide de string representation of this DsRect instance
        /// </summary>
        /// <returns>A string formated like this : [left, top - right, bottom]</returns>
        public override String ToString()
        {
            return String.Format(
                "[{0}, {1} - {2}, {3}]", 
                this.left, 
                this.top, 
                this.right, 
                this.bottom);
        }

        public override Int32 GetHashCode()
        {
            return this.left.GetHashCode() |
                this.top.GetHashCode() |
                this.right.GetHashCode() |
                this.bottom.GetHashCode();
        }

        public override Boolean Equals(Object obj)
        {
            return Equals((Rect)obj);
        }

        public Boolean Equals(Rect other)
        {
            return
                this.right == other.right &&
                this.bottom == other.bottom &&
                this.left == other.left &&
                this.top == other.top;
        }
    }
}
