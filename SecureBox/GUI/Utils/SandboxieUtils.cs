using GUI.Properties;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;

namespace GUI.Utils
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

        public bool StartSandboxed(string filePath)
        {
            if (! File.Exists(filePath))
                return false;

            string executer = SandboxieCommandLineExecutablePath();
            if (!File.Exists(executer))
                return false;

            Process.Start(executer, filePath);
            return true;
        }

        private string SandboxieCommandLineExecutablePath()
        {
            string programFiles = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
            string sandboxieCommandLineExecutablePath = Path.Combine(programFiles, Resources.SandboxieName,
                Resources.SandboxieCommandLineExecutable);

            return sandboxieCommandLineExecutablePath;
        }
    }
}