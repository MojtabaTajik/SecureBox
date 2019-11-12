using System;
using System.Diagnostics;
using System.Windows.Forms;
using GUI.Properties;
using GUI.Utils;

namespace GUI
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            var sandboxieAvailable = SandboxieUtils.SandboxieServiceAvailable();
            if (!sandboxieAvailable)
            {
                MessageBox.Show(Resources.SandboxieNotFound, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Process.Start(Resources.SandboxieWebsite);
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}