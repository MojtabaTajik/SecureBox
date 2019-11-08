using DokanNet;
using VirtualDrive.Core;

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
    }
}