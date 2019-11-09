using System;
using System.IO;
using VirtualDrive.Properties;

namespace VirtualDrive.Utils
{
    public static class PathUtils
    {
        public static string SecureBoxRealPath()
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string path = Path.Combine(appDataPath, Resources.VolumeLabel);

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            return path;
        }
    }
}