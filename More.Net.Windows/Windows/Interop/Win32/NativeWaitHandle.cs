using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Diagnostics;

namespace EZMetrology.Windows.Interop.Win32
{
    /// <summary>
    /// 
    /// </summary>
    public class NativeWaitHandle : WaitHandle
    {
        /// <summary>
        /// Copies the event handle, creating a new wait handle.
        /// </summary>
        /// <param name="hEvent"></param>
        public NativeWaitHandle(IntPtr hEvent) : 
            base()
        {
            Process currentProcess = Process.GetCurrentProcess();
            if (Kernel32.DuplicateHandle(
                currentProcess.Handle,
                hEvent,
                currentProcess.Handle,
                out hEvent,
                0,
                false,
                DuplicateOptions.SameAccess) == false)
                Marshal.ThrowExceptionForHR(Marshal.GetLastWin32Error());
            this.SafeWaitHandle = new SafeWaitHandle(hEvent, true);
        }
    }
}
