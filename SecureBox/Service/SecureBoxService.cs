using Data;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Service.Core;
using Shared.Utils;
using System.Threading;
using System.Threading.Tasks;

namespace Service
{
    public class SecureBoxService : IHostedService
    {
        private readonly ILogger<SecureBoxService> _logger;
        private readonly VirtualDrive.VirtualDrive _virtualDrive;

        public SecureBoxService(Database database, ILogger<SecureBoxService> logger)
        {
            _logger = logger;

            var config = database.Config.ReadConfig();
            var virtualDriveRequestHandler = new VirtualDriveRequestHandler(config);

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
    }
}