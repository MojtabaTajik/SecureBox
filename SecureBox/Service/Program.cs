using Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging.EventLog;

namespace Service
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddHostedService<SecureBoxService>()
                        .AddSingleton(new Database())
                        .Configure<EventLogSettings>(config =>
                        {
                            config.LogName = Properties.Resources.ServiceName;
                            config.SourceName = Properties.Resources.ServiceName;
                        });
                }).UseWindowsService();
    }
}