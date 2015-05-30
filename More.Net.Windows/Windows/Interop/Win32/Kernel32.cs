using System;
using System.Runtime.InteropServices;

namespace More.Net.Windows.Interop.Win32
{
    /// <summary>
    /// 
    /// </summary>
    public static class Kernel32
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hObject"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern Boolean CloseHandle(IntPtr hObject);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lpFileName"></param>
        /// <param name="dwDesiredAccess"></param>
        /// <param name="dwShareMode"></param>
        /// <param name="lpSecurityAttributes"></param>
        /// <param name="dwCreationDisposition"></param>
        /// <param name="dwFlagsAndAttributes"></param>
        /// <param name="hTemplateFile"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr CreateFile(
            String lpFileName,
            GenericAccess dwDesiredAccess,
            FileShare dwShareMode,
            IntPtr lpSecurityAttributes,
            CreationDisposition dwCreationDisposition,
            FileAttributes dwFlagsAndAttributes,
            IntPtr hTemplateFile);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hDevice"></param>
        /// <param name="dwIoControlCode"></param>
        /// <param name="InBuffer"></param>
        /// <param name="nInBufferSize"></param>
        /// <param name="OutBuffer"></param>
        /// <param name="nOutBufferSize"></param>
        /// <param name="pBytesReturned"></param>
        /// <param name="lpOverlapped"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern Boolean DeviceIoControl(
            IntPtr hDevice, UInt32 dwIoControlCode,
            IntPtr InBuffer, Int32 nInBufferSize,
            IntPtr OutBuffer, Int32 nOutBufferSize,
            out Int32 pBytesReturned, IntPtr lpOverlapped);

        /// <summary>
        /// Duplicates an object handle.
        /// </summary>
        /// <param name="hSourceProcessHandle">
        /// A handle to the process with the handle to be duplicated.
        /// </param>
        /// <param name="hSourceHandle">
        /// The handle to be duplicated. This is an open object handle that is valid in the context 
        /// of the source process.
        /// </param>
        /// <param name="hTargetProcessHandle">
        /// A handle to the process that is to receive the duplicated handle.
        /// </param>
        /// <param name="lpTargetHandle">
        /// A pointer to a variable that receives the duplicate handle. This handle value is valid 
        /// in the context of the target process.
        /// </param>
        /// <param name="dwDesiredAccess">
        /// The access requested for the new handle.
        /// </param>
        /// <param name="bInheritHandle">
        /// A variable that indicates whether the handle is inheritable. If true, the duplicate 
        /// handle can be inherited by new processes created by the target process. If false, the 
        /// new handle cannot be inherited.
        /// </param>
        /// <param name="dwOptions">
        /// Optional actions.
        /// </param>
        /// <returns></returns>
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern Boolean DuplicateHandle(
            [In] IntPtr hSourceProcessHandle,
            [In] IntPtr hSourceHandle,
            [In] IntPtr hTargetProcessHandle, 
            [Out] out IntPtr lpTargetHandle,
            [In] UInt32 dwDesiredAccess,
            [In] [MarshalAs(UnmanagedType.Bool)] Boolean bInheritHandle,
            [In] DuplicateOptions dwOptions);

        /// <summary>
        /// Retrieves a module handle for the specified module. The module must have been loaded by 
        /// the calling process.
        /// </summary>
        /// <param name="lpModuleName">
        /// The name of the loaded module (either a .dll or .exe file). If the file name extension 
        /// is omitted, the default library extension .dll is appended. The file name string can 
        /// include a trailing point character (.) to indicate that the module name has no 
        /// extension. The string does not have to specify a path. When specifying a path, be sure 
        /// to use backslashes (\), not forward slashes (/). The name is compared (case 
        /// independently) to the names of modules currently mapped into the address space of the 
        /// calling process.
        /// 
        /// If this parameter is null, GetModuleHandle returns a handle to the file used to create 
        /// the calling process (.exe file).
        /// 
        /// The GetModuleHandle function does not retrieve handles for modules that were loaded 
        /// using the LOAD_LIBRARY_AS_DATAFILE flag. For more information, see LoadLibraryEx.
        /// </param>
        /// <returns>Handle to the specified module or IntPtr.Zero if failure.</returns>
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr GetModuleHandle(String lpModuleName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lpAppName"></param>
        /// <param name="lpKeyName"></param>
        /// <param name="lpDefault"></param>
        /// <param name="lpReturnString"></param>
        /// <param name="nSize"></param>
        /// <param name="lpFilename"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll", 
            EntryPoint = "GetPrivateProfileStringW",
            SetLastError = true,
            CharSet = CharSet.Unicode, 
            ExactSpelling = true,
            CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 GetPrivateProfileStringW(
            String lpAppName, String lpKeyName, String lpDefault,
            String lpReturnString, Int32 nSize, String lpFilename);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Destination"></param>
        /// <param name="Source"></param>
        /// <param name="Length"></param>
        [DllImport("kernel32.dll", EntryPoint = "RtlMoveMemory")]
        public static extern void MoveMemory(IntPtr Destination, IntPtr Source, UInt32 Length);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dwDesiredAccess"></param>
        /// <param name="bInheritHandle"></param>
        /// <param name="dwThreadId"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr OpenThread(ThreadAccess dwDesiredAccess,
            Boolean bInheritHandle, UInt32 dwThreadId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hThread"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern UInt32 ResumeThread(IntPtr hThread);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hThread"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern UInt32 SuspendThread(IntPtr hThread);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lpAppName"></param>
        /// <param name="lpKeyName"></param>
        /// <param name="lpString"></param>
        /// <param name="lpFilename"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll", 
            EntryPoint = "WritePrivateProfileStringW",
            SetLastError = true,
            CharSet = CharSet.Unicode, 
            ExactSpelling = true,
            CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 WritePrivateProfileStringW(
            String lpAppName, String lpKeyName,
            String lpString, String lpFilename);
    }
}
