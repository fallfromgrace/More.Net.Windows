using System;

namespace EZMetrology.Windows.Interop.Win32
{
    /// <summary>
    /// Set of flags that determine thread access level.
    /// </summary>
    [Flags]
    public enum ThreadAccess
    {
        /// <summary>
        /// Required to terminate a thread using TerminateThread.
        /// </summary>
        TERMINATE = 0x0001,

        /// <summary>
        /// Required to suspend or resume a thread (see SuspendThread and ResumeThread).
        /// </summary>
        SUSPEND_RESUME = 0x0002,

        /// <summary>
        /// Required to read the context of a thread using GetThreadContext.
        /// </summary>
        GET_CONTEXT = 0x0008,

        /// <summary>
        /// Required to write the context of a thread using SetThreadContext.
        /// </summary>
        SET_CONTEXT = 0x0010,

        /// <summary>
        /// Required to set certain information in the thread object.
        /// </summary>
        SET_INFORMATION = 0x0020,

        /// <summary>
        /// Required to read certain information from the thread object, such as the exit code 
        /// (see GetExitCodeThread).
        /// </summary>
        QUERY_INFORMATION = 0x0040,

        /// <summary>
        /// Required to set the impersonation token for a thread using SetThreadToken.
        /// </summary>
        SET_THREAD_TOKEN = 0x0080,

        /// <summary>
        /// Required to use a thread's security information directly without calling it by using 
        /// a communication mechanism that provides impersonation services.
        /// </summary>
        IMPERSONATE = 0x0100,

        /// <summary>
        /// Required for a server thread that impersonates a client.
        /// </summary>
        DIRECT_IMPERSONATION = 0x0200,

        /// <summary>
        /// Required to set certain information in the thread object. A handle that has the 
        /// THREAD_SET_INFORMATION access right is automatically granted 
        /// THREAD_SET_LIMITED_INFORMATION.
        /// </summary>
        THREAD_SET_LIMITED_INFORMATION = 0x0400,

        /// <summary>
        /// Required to read certain information from the thread objects (see 
        /// GetProcessIdOfThread). A handle that has the THREAD_QUERY_INFORMATION access right 
        /// is automatically granted THREAD_QUERY_LIMITED_INFORMATION.
        /// </summary>
        THREAD_QUERY_LIMITED_INFORMATION = 0x0800,

        /// <summary>
        /// Enables the use of the thread handle in any of the wait functions.
        /// </summary>
        SYNCHRONIZE = 0x00100000
    }
}
