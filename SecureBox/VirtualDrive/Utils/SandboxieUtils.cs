using System.Linq;
using System.ServiceProcess;
using VirtualDrive.Properties;

namespace VirtualDrive.Utils
{
    internal class SandboxieUtils
    {
        public bool SandboxieInstalled()
        {
            var installedServices = ServiceController.GetServices().ToList();

            return installedServices.Exists(c => c.ServiceName.Equals(Resources.SandboxieServiceName));
        }

        public bool IsSandboxieServiceAvailable()
        {
            var installedServices = ServiceController.GetServices().ToList();

            return installedServices.FirstOrDefault(f => f.ServiceName.Equals(Resources.SandboxieServiceName))
                       ?.Status == ServiceControllerStatus.Running;
        }
    }
}