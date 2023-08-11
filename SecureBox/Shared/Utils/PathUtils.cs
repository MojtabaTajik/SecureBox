using Shared.Properties;
using System;
using System.IO;

namespace Shared.Utils
{
    public static class PathUtils
    {
        /// <summary>
        /// Use CommonApplicationData because our service & UI program run under different user accounts and should have same storage path
        /// </summary>
        public static string AppDataPath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
        }

        public static string ProgramFilesPath() => Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);

        public static string ConfigPath()
        {
            string path = Path.Combine(AppDataPath(), Resources.AppName);

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            return path;
        }

        public static string VirtualDriveMirrorPath()
        {
            string path = Path.Combine(ConfigPath(), Resources.VirtualDriveStorageName);

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            return path;
        }
    }
}