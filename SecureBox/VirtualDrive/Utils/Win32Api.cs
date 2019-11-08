using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;

namespace VirtualDrive.Utils
{
    public class Win32Api
    {
        [DllImport("kernel32", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetFileTime(SafeFileHandle hFile, ref long lpCreationTime, ref long lpLastAccessTime, ref long lpLastWriteTime);

    }
}