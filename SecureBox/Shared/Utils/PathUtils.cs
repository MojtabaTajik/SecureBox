using System;
using System.IO;
using Shared.Properties;

namespace Shared.Utils
{
    public static class PathUtils
    {
        private static string AppDataPath() => Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

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