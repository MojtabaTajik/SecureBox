using GUI.Utils;
using System.Windows.Forms;
using ZetaIpc.Runtime.Server;

namespace GUI
{
    public partial class Main : Form
    {
        private readonly SandboxieUtils _sandboxie;

        public Main()
        {
            var ipc = new IpcServer();
            ipc.ReceivedRequest += IpcOnReceivedRequest;
            ipc.Start(7524);

            _sandboxie = new SandboxieUtils();

            InitializeComponent();
        }

        private void IpcOnReceivedRequest(object sender, ReceivedRequestEventArgs e)
        {
            string filePath = e.Request;
            _sandboxie.StartSandboxed(filePath);

            e.Handled = true;
        }
    }
}