using DokanNet;
using System.Collections.Generic;
using System.IO;
using VirtualDrive.Core;

namespace VirtualDrive
{
    public class VirtualDrive
    {
        private readonly SecureVirtualDrive _virtualDrive;
        private string _mountPoint;

        public VirtualDrive(SecureVirtualDrive virtualDrive)
        {
            _virtualDrive = virtualDrive;
        }

        public string MoundVirtualDrive()
        {
            try
            {
                _mountPoint = DriveLetter.UnusedDriveLetter();

                _virtualDrive.Mount(_mountPoint, DokanOptions.DebugMode | DokanOptions.EnableNotificationAPI, 5);

                return _mountPoint;
            }
            catch (DokanException ex)
            {
                throw;
            }
        }

        public bool UnmountVirtualDrive()
        {
            if (_mountPoint == null)
                return false;

            return Dokan.Unmount(_mountPoint[0]);
        }

        private IEnumerable<char> CurrentDrivesLetters()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo driveInfo in allDrives)
            {
                yield return driveInfo.Name[0];
            }
        }
    }
}