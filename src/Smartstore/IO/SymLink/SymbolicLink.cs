using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace Smartstore.IO.SymLinks
{
    internal static class SymbolicLink
    {
        // TODO: (core) Make this run on Unix/Mac
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CreateFile(
            [MarshalAs(UnmanagedType.LPTStr)] string filename,
            [MarshalAs(UnmanagedType.U4)] uint access,
            [MarshalAs(UnmanagedType.U4)] FileShare share,
            IntPtr securityAttributes, // optional SECURITY_ATTRIBUTES struct or IntPtr.Zero
            [MarshalAs(UnmanagedType.U4)] FileMode creationDisposition,
            [MarshalAs(UnmanagedType.U4)] uint flagsAndAttributes,
            IntPtr templateFile);

        //[DllImport("kernel32.dll", EntryPoint = "CreateSymbolicLinkW", CharSet = CharSet.Unicode, SetLastError = true)]
        //private static extern bool CreateSymbolicLink(
        //	[In] string lpSymlinkFileName,
        //	[In] string lpTargetFileName,
        //	[In] int dwFlags);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern uint GetFinalPathNameByHandle(
            IntPtr hFile,
            [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpszFilePath,
            uint cchFilePath,
            uint dwFlags);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool CloseHandle(IntPtr hObject);

        private const int FILE_FLAG_BACKUP_SEMANTICS = 0x02000000;
        private const uint FILE_READ_EA = 0x0008;

        private static readonly IntPtr INVALID_HANDLE_VALUE = new IntPtr(-1);

        public static bool IsSymbolicLink(FileSystemInfo fsi, out string finalPathName)
        {
            Guard.NotNull(fsi, nameof(fsi));

            finalPathName = null;

            // FileSystemInfo.Exists has some problems with symbolic links
            var exists = (fsi is DirectoryInfo)
                ? Directory.Exists(fsi.FullName)
                : File.Exists(fsi.FullName);

            if (!exists)
                return false;

            if (fsi.Attributes.HasFlag(FileAttributes.ReparsePoint))
            {
                var target = GetFinalPathName(fsi.FullName);
                if (target.HasValue())
                {
                    if (!string.Equals(target.TrimEnd('\\'), fsi.FullName.TrimEnd('\\'), StringComparison.OrdinalIgnoreCase))
                    {
                        finalPathName = target;
                        return true;
                    }

                    return false;
                }
            }

            return false;
        }

        public static string GetFinalPathName(string path)
        {
            Guard.NotEmpty(path, nameof(path));

            var h = CreateFile(path,
                FILE_READ_EA,
                FileShare.ReadWrite | FileShare.Delete,
                IntPtr.Zero,
                FileMode.Open,
                FILE_FLAG_BACKUP_SEMANTICS,
                IntPtr.Zero);

            if (h == INVALID_HANDLE_VALUE)
            {
                throw new Win32Exception(Marshal.GetLastWin32Error());
            }

            try
            {
                var sb = new StringBuilder(1024);
                var res = GetFinalPathNameByHandle(h, sb, 1024, 0);
                if (res == 0)
                {
                    throw new Win32Exception(Marshal.GetLastWin32Error());
                }

                var result = sb.ToString();

                if (result.Length >= 4 && result.StartsWith(@"\\?\"))
                {
                    return result[4..];// remove "\\?\"
                }

                return result;
            }
            finally
            {
                CloseHandle(h);
            }
        }
    }
}