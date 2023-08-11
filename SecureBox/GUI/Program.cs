using GUI.Properties;
using GUI.Utils;
using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            var sandboxieAvailable = SandboxieUtils.SandboxieServiceAvailable();
            if (!sandboxieAvailable)
            {
                MessageBox.Show(Resources.SandboxieNotFound, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Process.Start(Resources.SandboxieWebsite);
                return;
            }

            _ = new Mutex(true, Resources.MutexName, out bool notCreated);
            if (notCreated)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Main());
            }
        }
    }
}