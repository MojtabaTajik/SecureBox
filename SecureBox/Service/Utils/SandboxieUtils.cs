using Service.Properties;
using System.Linq;
using System.ServiceProcess;

namespace Service.Utils
{
    public class SandboxieUtils
    {
        public bool SandboxieInstalled()
        {
            var installedServices = ServiceController.GetServices().ToList();

            return installedServices.Exists(c => c.ServiceName.Equals(Resources.SandboxieServiceName));
        }

        public bool SandboxieServiceAvailable()
        {
            var installedServices = ServiceController.GetServices().ToList();

            return installedServices.FirstOrDefault(f => f.ServiceName.Equals(Resources.SandboxieServiceName))
                       ?.Status == ServiceControllerStatus.Running;
        }
    }
}