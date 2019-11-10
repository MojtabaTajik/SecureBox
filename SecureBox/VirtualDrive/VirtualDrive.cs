using DokanNet;
using System;
using System.IO;
using VirtualDrive.Core;
using VirtualDrive.Properties;
using VirtualDrive.Types;

namespace VirtualDrive
{
    public class VirtualDrive
    {
        public RequestFileOpen OnRequestFileOpen { get; set; }

        private readonly VirtualDriveImpl _virtualDrive;
        private string _mountPoint;

        public VirtualDrive(string path)
        {
            _virtualDrive = new VirtualDriveImpl(path);
        }

        public string MountVirtualDrive()
        {
            try
            {
                _virtualDrive.OnRequestFileOpen += OnRequestFileOpen;

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

            return Dokan.Unmount(_mountPoint[0]) && Dokan.RemoveMountPoint(_mountPoint);
        }

        private string GetMountPoint()
        {
            var drivesInfo = DriveInfo.GetDrives();

            foreach (DriveInfo driveInfo in drivesInfo)
            {
                try
                {
                    if (driveInfo.DriveFormat == Resources.FileSystem)
                        return driveInfo.RootDirectory.FullName;
                }
                catch (Exception ex)
                {
                    
                }
            }

            return null;
        }
    }
}