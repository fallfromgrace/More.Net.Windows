using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace More.Net.Windows.Interop
{
    //public struct CAUUID
    //{
    //    public Int32 cElems;
    //    public Guid[] guids;
    //}

    /// <summary>
    /// From CAUUID
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DsCAUUID
    {
        public int cElems;
        public IntPtr pElems;

        /// <summary>
        /// Perform a manual marshaling of pElems to retrieve an array of System.Guid.
        /// Assume this structure has been already filled by the ISpecifyPropertyPages.GetPages() method.
        /// </summary>
        /// <returns>A managed representation of pElems (cElems items)</returns>
        public Guid[] ToGuidArray()
        {
            Guid[] retval = new Guid[this.cElems];

            for (int i = 0; i < this.cElems; i++)
            {
                IntPtr ptr = new IntPtr(this.pElems.ToInt64() + (Marshal.SizeOf(typeof(Guid)) * i));
                retval[i] = (Guid)Marshal.PtrToStructure(ptr, typeof(Guid));
            }

            return retval;
        }
    }
}
