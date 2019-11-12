using System.Threading.Tasks;
using DokanNet;
using Model.Entities;
using Shared.Types;
using ZetaIpc.Runtime.Client;

namespace Service.Core.RequestHandlers
{
    public class VirtualDriveRequestHandler
    {
        private readonly ConfigEntity _config;
        private readonly IpcClient _ipcClient;

        public VirtualDriveRequestHandler(ConfigEntity config, IpcClient ipcClient)
        {
            _config = config;
            _ipcClient = ipcClient;
        }

        public NtStatus OnRequestFileOpen(string filepath)
        {
            switch (_config.ProtectMode)
            {
                case ProtectMode.None:
                    return DokanResult.AccessDenied;

                case ProtectMode.SandboxAll:
                {
                    Task.Run(() => _ipcClient.Send(filepath));
                    return DokanResult.Unsuccessful;
                }

                case ProtectMode.ScanAll:
                {
                    return DokanResult.AccessDenied;
                }

                case ProtectMode.ScanThenSandbox:
                {
                    return DokanResult.AccessDenied;
                }

                default:
                    return DokanResult.AccessDenied;
            }
        }
    }
}