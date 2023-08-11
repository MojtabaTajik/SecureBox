using GUI.Properties;
using GUI.Utils;
using System.Windows.Forms;
using ZetaIpc.Runtime.Client;
using ZetaIpc.Runtime.Server;

namespace GUI
{
    public partial class Main : Form
    {
        private bool _closeApp = false;
        private readonly IpcClient _ipcClient = new IpcClient();
        private readonly SandboxieUtils _sandboxie;

        public Main()
        {
            var ipc = new IpcServer();
            ipc.ReceivedRequest += IpcOnReceivedRequest;
            ipc.Start(Shared.Constants.GUIIpcServerPort);

            _sandboxie = new SandboxieUtils();

            InitializeComponent();
        }

        private void IpcOnReceivedRequest(object sender, ReceivedRequestEventArgs e)
        {
            string filePath = e.Request;
            _sandboxie.StartSandboxed(filePath);

            e.Handled = true;
        }

        private void bntApply_Click(object sender, System.EventArgs e)
        {
            _ipcClient.Initialize(Shared.Constants.ServerIpcServerPort);
            _ipcClient.Send("VT:{}");
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_closeApp == false)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void notifyIcon_DoubleClick(object sender, System.EventArgs e)
        {
            this.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var dialogResult = MessageBox.Show(Resources.CloseAppConfirm, string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                _closeApp = true;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}