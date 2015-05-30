using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace More.Net.Windows.Interop.Win32
{
    /// <summary>
    /// Contains various .NET implementation of native Win32 API functions.
    /// </summary>
    public static class Native
    {
        #region Public Methods

        /// <summary>
        /// Creates a *.def, *.lib, and *.exp file from a C/C++ *.dll.
        /// </summary>
        /// <remarks>
        /// This probably should be separate script, but meh... you 
        /// would ever need to run it once most likely.
        /// </remarks>
        /// <param name="dllpath">Full path the dll.</param>
        /// <returns>True if library was successfully created</returns>
        public static Boolean CreateImportLibrary(String dllpath)
        {
            Process cmdProcess;
            ProcessStartInfo cmdStartInfo;
            String noext, defPath, libPath, getSymbolsCmd, getLibCmd, line;
            String[] lineOut;
            Int32 i;
            StreamWriter input;
            StreamReader error, output;
            Boolean status;

            status = false;
            cmdStartInfo = new ProcessStartInfo()
            {
                UseShellExecute = false,
                WindowStyle = ProcessWindowStyle.Hidden,
                FileName = Environment.GetEnvironmentVariable(CmdKey),
                Arguments = String.Format("{0} {1}",
                    CmdArg,
                    String.Format("\"{0}{1}\"",
                        Environment.GetEnvironmentVariable(VSToolsDirKey),
                        VSCmdName)),
                RedirectStandardInput = true,
                RedirectStandardError = true,
                RedirectStandardOutput = true
            };
            noext = dllpath.Remove(dllpath.Length - ExtLen);
            defPath = noext + "def";
            libPath = noext + "lib";

            getSymbolsCmd = String.Format(
                "dumpbin /exports \"{0}\"", dllpath);
            getLibCmd = String.Format(
                "lib /def:\"{0}\" /OUT:\"{1}\"", defPath, libPath);

            cmdProcess = Process.Start(cmdStartInfo);
            input = cmdProcess.StandardInput;
            output = cmdProcess.StandardOutput;
            error = cmdProcess.StandardError;

            input.WriteLine(getSymbolsCmd);
            input.Close();
            if (error.ReadToEnd() == "")
            {
                lineOut = output.ReadToEnd().Split('\n');
                cmdProcess.Close();

                using (StreamWriter writer = new StreamWriter(defPath))
                {
                    writer.WriteLine("EXPORTS");
                    i = 21;
                    while ((line = lineOut[i]) != "")
                    {
                        writer.WriteLine(line.Split(' ').Last());
                        i++;
                    }
                }

                if (cmdProcess.Start())
                {
                    input = cmdProcess.StandardInput;
                    output = cmdProcess.StandardOutput;
                    error = cmdProcess.StandardError;

                    input.WriteLine(getLibCmd);
                    input.Close();

                    if (error.ReadToEnd() == "" &&
                        File.Exists(libPath))
                    {
                        status = true;
                    }
                }
            }

            cmdProcess.Close();

            return status;
        }

        /// <summary>
        /// Suspends a process thread.
        /// </summary>
        /// <param name="thread"></param>
        public static void SuspendProcessThread(ProcessThread thread)
        {
            UInt32 err;
            Boolean success;
            IntPtr hThread;
            hThread = Kernel32.OpenThread(ThreadAccess.SUSPEND_RESUME, false, (UInt32)thread.Id);
            err = Kernel32.SuspendThread(hThread);
            success = Kernel32.CloseHandle(hThread);
        }

        /// <summary>
        /// Resumes a process thread.
        /// </summary>
        /// <param name="thread"></param>
        public static void ResumeProcessThread(ProcessThread thread)
        {
            UInt32 err;
            Boolean success;
            IntPtr hThread;
            hThread = Kernel32.OpenThread(ThreadAccess.SUSPEND_RESUME, false, (UInt32)thread.Id);
            err = Kernel32.ResumeThread(hThread);
            success = Kernel32.CloseHandle(hThread);
        }

        #endregion

        #region Constants

        private const String VSToolsDirKey = "VS110COMNTOOLS";
        private const String VSCmdName = "VsDevCmd.bat";
        private const String CmdKey = "comspec";
        private const String CmdArg = "/k";
        private const Int32 ExtLen = 3;

        #endregion
    }
}
