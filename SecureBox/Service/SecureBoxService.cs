using Microsoft.Extensions.Hosting;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Service
{
    public class SecureBoxService : IHostedService
    {
        private readonly ILogger<SecureBoxService> _logger;
        private readonly VirtualDrive.VirtualDrive _virtualDrive;

        public SecureBoxService(ILogger<SecureBoxService> logger, VirtualDrive.VirtualDrive virtualDrive)
        {
            _logger = logger;
            _virtualDrive = virtualDrive;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Service start");

            var startTask = new Task(() =>
            {
                _virtualDrive.MoundVirtualDrive();
            }, cancellationToken);

            startTask.Start();

            return startTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Service Stop");

            var stopTask = new Task(() =>
            {
                _virtualDrive.UnmountVirtualDrive();
            }, cancellationToken);

            stopTask.Start();

            return stopTask;
        }
    }
}