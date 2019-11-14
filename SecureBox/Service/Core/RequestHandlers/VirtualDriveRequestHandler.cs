using DokanNet;
using Model.Entities;
using Shared.Types;
using System;
using System.Threading.Tasks;
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
                case ProtectMode.SandboxAll:
                    {
                        Task.Run(() =>
                        {
                            try
                            {
                                return _ipcClient.Send(filepath);
                            }
                            catch (Exception e)
                            {
                                return null;
                            }
                        });

                        return DokanResult.FileNotFound;
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