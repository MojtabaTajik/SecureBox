using Data;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Service.Core.RequestHandlers;
using Shared.Utils;
using System.Threading;
using System.Threading.Tasks;
using ZetaIpc.Runtime.Client;
using ZetaIpc.Runtime.Server;

namespace Service
{
    public class SecureBoxService : IHostedService
    {
        private readonly ILogger<SecureBoxService> _logger;
        private readonly VirtualDrive.VirtualDrive _virtualDrive;

        public SecureBoxService(Database database, ILogger<SecureBoxService> logger)
        {
            _logger = logger;

            // IPC initialization
            var ipcServer = new IpcServer();
            ipcServer.ReceivedRequest += OnCommandReceived;
            ipcServer.Start(Shared.Constants.ServerIpcServerPort);

            var ipcClient = new IpcClient();
            ipcClient.Initialize(Shared.Constants.GUIIpcServerPort);

            var config = database.Config.ReadConfig();
            var virtualDriveRequestHandler = new VirtualDriveRequestHandler(config, ipcClient);

            _virtualDrive = new VirtualDrive.VirtualDrive(PathUtils.VirtualDriveMirrorPath());
            _virtualDrive.OnRequestFileOpen += virtualDriveRequestHandler.OnRequestFileOpen;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Service start");

            var startTask = new Task(() =>
            {
                _virtualDrive.MountVirtualDrive();
            }, cancellationToken);

            startTask.Start();

            return startTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Service Stop");

            _virtualDrive.UnMountVirtualDrive();
            var stopTask = new Task(() =>
            {
            }, cancellationToken);

            stopTask.Start();

            return stopTask;
        }

        private void OnCommandReceived(object sender, ReceivedRequestEventArgs receivedRequestEventArgs)
        {
            throw new System.NotImplementedException();
        }
    }
}