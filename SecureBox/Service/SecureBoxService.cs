using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;
using VirtualDrive.Utils;

namespace Service
{
    public class SecureBoxService : IHostedService
    {
        private readonly ILogger<SecureBoxService> _logger;
        private readonly VirtualDrive.VirtualDrive _virtualDrive;

        public SecureBoxService(ILogger<SecureBoxService> logger)
        {
            _logger = logger;
            _virtualDrive = new VirtualDrive.VirtualDrive(PathUtils.SecureBoxRealPath());
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