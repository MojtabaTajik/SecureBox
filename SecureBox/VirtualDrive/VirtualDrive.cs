using DokanNet;
using System.IO;
using System.Linq;
using VirtualDrive.Core;
using VirtualDrive.Properties;

namespace VirtualDrive
{
    public class VirtualDrive
    {
        private readonly SecureVirtualDrive _virtualDrive;
        private string _mountPoint;

        public VirtualDrive(string path)
        {
            _virtualDrive = new SecureVirtualDrive(path);
        }

        public string MountVirtualDrive()
        {
            try
            {
                // Get mount point, maybe the SecureBox file system already mounted
                _mountPoint = GetMountPoint();

                if (string.IsNullOrEmpty(_mountPoint))
                {
                    _mountPoint = DriveLetter.UnusedDriveLetter();

                    _virtualDrive.Mount(_mountPoint, DokanOptions.DebugMode | DokanOptions.EnableNotificationAPI, 5);
                }

                return _mountPoint;
            }
            catch (DokanException ex)
            {
                throw;
            }
        }

        public bool UnMountVirtualDrive()
        {
            if (_mountPoint == null)
                return false;

            return Dokan.Unmount(_mountPoint[0]);
        }

        private string GetMountPoint() => DriveInfo.GetDrives()
            .FirstOrDefault(drive => drive.DriveFormat == Resources.FileSystem)?.RootDirectory?.FullName;
    }
}