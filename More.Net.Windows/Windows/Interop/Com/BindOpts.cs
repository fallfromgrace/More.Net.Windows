using System;

namespace More.Net.Windows.Interop.Com
{
    /// <summary>
    /// 
    /// </summary>
    public struct BindOpts
    {
        // Summary:
        //     Specifies the size of the BIND_OPTS structure in bytes.
        public UInt32 cbStruct;
        //
        // Summary:
        //     Indicates the amount of time (clock time in milliseconds, as returned by
        //     the GetTickCount function) the caller specified to complete the binding operation.
        public UInt32 dwTickCountDeadline;
        //
        // Summary:
        //     Controls aspects of moniker binding operations.
        public BindFlags grfFlags;
        //
        // Summary:
        //     Flags that should be used when opening the file that contains the object
        //     identified by the moniker.
        public StgM grfMode;
    }
}
